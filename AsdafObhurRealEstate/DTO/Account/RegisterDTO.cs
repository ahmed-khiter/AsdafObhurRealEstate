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
        [Display(Name ="الأسم الأول")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name ="الأسم الثاني")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name ="البريد الألكترونى")]
        public string Email { get; set;}

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name ="رقم التلفون")]
        public string Phonenumber { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "الرقم السري")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password),Display(Name ="تأكيد الرقم السرى"),Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }

        public AccountType AccountType { get; set; }
    }
}
