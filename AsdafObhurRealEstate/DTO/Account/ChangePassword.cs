using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;


namespace AsdafObhurRealEstate.DTO.Account
{
    public class ChangePassword
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "الرقم السري القديم")]
        public string OldPassword { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "الرقم السري الجديد")]
        public string NewPassword { get; set; }

        [Required]
        [DataType(DataType.Password), Display(Name = "تأكيد الرقم السرى"), Compare(nameof(NewPassword))]
        public string ConfirmPassword { get; set; }


    }
}
