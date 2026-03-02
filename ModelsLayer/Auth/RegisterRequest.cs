using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLayer.Auth
{
    public class RegisterRequest
    {
        [Required, MaxLength(100)]
        public string FullName { get; set; }

        [Required, MaxLength(20)]
        public string PhoneNumber { get; set; }

        [MaxLength(100)]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        public short CountryId { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required, MinLength(6)]
        public string Password { get; set; }
    }
}
