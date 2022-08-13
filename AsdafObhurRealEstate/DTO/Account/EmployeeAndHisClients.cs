using AsdafObhurRealEstate.Enums;
using System.ComponentModel.DataAnnotations;

namespace AsdafObhurRealEstate.DTO.Account
{
    public class EmployeeAndHisClients
    {
        public string UserId { get; set; }

        [Display(Name = "كود الموظف")]
        public int EmployeeCode { get; set; }

        [Display(Name = "من")]
        public DateTime From { get; set; }

        [Display(Name="إلى")]
        public DateTime To { get; set; }

        [Display(Name="اسم الموظف")]
        public string Name { get; set; }

        [Display(Name="رقم جوال الموظف")]
        public string PhoneNumber { get; set; }

        [Display(Name="البريد الإلكتروني")]
        public string Email { get; set; }

        public List<ClientDetailsDto> ClientsWhoCreated { get; set; }
        public List<ClientDetailsDto> ClientsWhoHandled { get; set; }

    }
    public class ClientDetailsDto
    {
        public string ClientId { get; set; }

        [Display(Name="كود العميل")]
        public int ClientCode { get; set; }

        [Display(Name="اسم العميل")]
        public string Name { get; set; }

        [Display(Name="رقم جوال العميل")]
        public string PhoneNumber { get; set; }

        [Display(Name="حالة")]
        public StatusOfClient Status { get; set; }
    }
    
}
