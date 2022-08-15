using System.ComponentModel.DataAnnotations;

namespace AsdafObhurRealEstate.DTO.ClientsDataTransferObject
{
    public class CreateClientDTO
    {
        [Required(ErrorMessage ="اسم العميل إجباري")]
        [Display(Name ="اسم العميل")]
        public string ClientName { get; set; }

        public string ClientId { get; set; }

        [Display(Name ="عنوان")]
        [Required(ErrorMessage ="عنوان اجباري")]
        public string Address { get; set; }


        [Display(Name ="رقم التلفون")]
        [Required(ErrorMessage = "رقم التلفون إجبارى")]
        public string PhoneNumber { get; set; }

        [Display(Name ="اختار القسم")]
        public string DepartmentId { get; set; }

        [Display(Name = "الموظفين")]
        public string BaseUserId { get; set; }

    }
}
