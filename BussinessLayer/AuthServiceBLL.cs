using BCrypt.Net;
using DataLayer;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using ModelsLayer;
using ModelsLayer.Auth;
using StudentApi.Model.Auth;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public interface IAuthService
    {
        Task<TokenResponse> LoginAsync(LoginRequest request);
        Task RegisterAsync(RegisterRequest request);
        Task<TokenResponse> RefreshAsync(RefreshRequest request);
        Task<bool> LogoutAsync(LogoutRequest request);
    }

    public class AuthServiceBLL : IAuthService
    {
        private readonly IConfiguration _configuration;
        private readonly ICustomersBLL _customers;

        public AuthServiceBLL(IConfiguration configuration, ICustomersBLL customers)
        {
            _configuration = configuration;
            _customers = customers;
        }

        public async Task<TokenResponse> LoginAsync(LoginRequest request)
        {
            var client = await _customers.GetGetCustomerByPhoneNumber(request.PhoneNumber);

            if (client == null)
                throw new UnauthorizedAccessException("Invalid credentials");

            if (!BCrypt.Net.BCrypt.Verify(request.Password, client.Password))
                throw new UnauthorizedAccessException("Invalid credentials");

            var accessToken = GenerateAccessToken(client);
            var refreshToken = GenerateRefreshToken();

            client.RefreshTokenHash = BCrypt.Net.BCrypt.HashPassword(refreshToken);
            client.RefreshTokenExpiresAt = DateTime.UtcNow.AddDays(7);
            client.RefreshTokenRevokedAt = null;

           _customers.UpdateRefreshToken(client);

            return new TokenResponse
            {
                AccessToken = accessToken,
                RefreshToken = refreshToken
            };
        }

        public async Task RegisterAsync(RegisterRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.PhoneNumber) ||
                string.IsNullOrWhiteSpace(request.Password))
                throw new Exception("Invalid data");

            var existing = await _customers.GetGetCustomerByPhoneNumber(request.PhoneNumber);

            if (existing != null)
                throw new Exception("Phone number already exists");

            var customer = new Customers
            {
                FullName = request.FullName,
                PhoneNumber = request.PhoneNumber,
                Email = request.Email,
                DateOfBirth = request.DateOfBirth,
                CountryId = request.CountryId,
                Password = BCrypt.Net.BCrypt.HashPassword(request.Password),
                IsActive = true,
                Role = "Client"
            };

            _customers.Register(customer);
        }

        public async Task<TokenResponse> RefreshAsync(RefreshRequest request)
        {
            var client = await _customers.GetGetCustomerByPhoneNumber(request.PhoneNumber);

            if (client == null)
                throw new UnauthorizedAccessException("Invalid refresh request");

            if (client.RefreshTokenRevokedAt != null)
                throw new UnauthorizedAccessException("Refresh token is revoked");

            if (client.RefreshTokenExpiresAt == null || client.RefreshTokenExpiresAt <= DateTime.UtcNow)
                throw new UnauthorizedAccessException("Refresh token expired");

            if (!BCrypt.Net.BCrypt.Verify(request.RefreshToken, client.RefreshTokenHash))
                throw new UnauthorizedAccessException("Invalid refresh token");

            var newAccessToken = GenerateAccessToken(client);
            var newRefreshToken = GenerateRefreshToken();

            client.RefreshTokenHash = BCrypt.Net.BCrypt.HashPassword(newRefreshToken);
            client.RefreshTokenExpiresAt = DateTime.UtcNow.AddDays(7);
            client.RefreshTokenRevokedAt = null;

            _customers.UpdateRefreshToken(client);

            return new TokenResponse
            {
                AccessToken = newAccessToken,
                RefreshToken = newRefreshToken
            };
        }

        public async Task<bool> LogoutAsync(LogoutRequest request)
        {
            var client = await _customers.GetGetCustomerByPhoneNumber(request.PhoneNumber);

            if (client == null)
                return false;

            if (string.IsNullOrEmpty(request.RefreshToken) || string.IsNullOrEmpty(client.RefreshTokenHash))
                return false;

            bool refreshValid = BCrypt.Net.BCrypt.Verify(request.RefreshToken, client.RefreshTokenHash);

            if (!refreshValid)
                return false;

            client.RefreshTokenRevokedAt = DateTime.UtcNow;

             _customers.UpdateRefreshToken(client);

            return true;
        }


        
        // ================== Private Helpers ==================

        private string GenerateAccessToken(Customers client)
        {
            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, client.CustomerID.ToString()),
                new Claim(ClaimTypes.MobilePhone, client.PhoneNumber),
                new Claim(ClaimTypes.Role, client.Role)
            };

            var secretKey = _configuration["BusBooking_JWT_Key"];

            if (string.IsNullOrWhiteSpace(secretKey))
                throw new Exception("JWT secret key is not configured.");

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: "BusBookingSystem",
                audience: "BusBookingUsers",
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(30),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        private static string GenerateRefreshToken()
        {
            var bytes = new byte[64];
            using var rng = RandomNumberGenerator.Create();
            rng.GetBytes(bytes);
            return Convert.ToBase64String(bytes);
        }
    }
}
