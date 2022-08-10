using AsdafObhurRealEstate.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AsdafObhurRealEstate.DTO.Account
{
    public class RegisterDTO
    {
        [Required]
        [Display(Name ="First name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name ="Last name")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set;}

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Phonenumber { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password),Display(Name ="Confirm password"),Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }

        public AccountType AccountType { get; set; }
    }
}
