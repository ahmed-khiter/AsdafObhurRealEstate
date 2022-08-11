using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AsdafObhurRealEstate.DTO.Account
{
    public class LoginDTO
    {
        [Required]
        [Display(Name = "البريد الالكتروني")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "الرقم السرى")]
        public string Password { get; set; }

        [Display(Name = "ابقى على تسجيل الدخول")]
        public bool RememberMe { get; set; }

    }
}
