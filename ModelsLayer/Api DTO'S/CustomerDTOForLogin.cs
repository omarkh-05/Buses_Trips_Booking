using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLayer
{
    [NotMapped]
    public class CustomerDTOForLogin
    {
        public int CustomerID { get; set; }

        public string FullName { get; set; }

        public string PasswordHash { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public bool IsActive { get; set; }

        public DateTime DateOfBirth { get; set; }

        public short CountryId { get; set; }

    }
}
