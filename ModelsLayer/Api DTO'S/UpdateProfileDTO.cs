using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLayer.Api_DTO_S
{
    public class UpdateProfileDTO
    {
        public string FullName { get; set; }

        public string PhoneNumber { get; set; }

        public string? Email { get; set; } = null;

        public string? Description { get; set; } = null;

        public IFormFile? Image { get; set; } = null;
    }
}
