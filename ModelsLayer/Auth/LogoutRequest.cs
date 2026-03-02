namespace StudentApi.Model.Auth
{
    public class LogoutRequest
    {
        public string PhoneNumber { get; set; }
        public string RefreshToken { get; set; }
    }
}
