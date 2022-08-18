using AsdafObhurRealEstate.Enums;
using AsdafObhurRealEstate.Helpers;
using AsdafObhurRealEstate.Models;
using System.ComponentModel.DataAnnotations;

namespace AsdafObhurRealEstate.DTO.Account
{
    public class GenerateReportDTO
    {
        public string UserId { get; set; }

        public DateTime From { get; set; }

        public DateTime To { get; set; }

        public string BaseUrl { get; set; }

        [Display(Name = "كود الموظف")]
        public int EmployeeCode { get; set; }

        [Display(Name = "اسم الموظف")]
        public string Name { get; set; }

        [Display(Name = "رقم جوال الموظف")]
        public string PhoneNumber { get; set; }

        [Display(Name = "البريد الإلكتروني")]
        public string Email { get; set; }

        public List<ReportData> ClientsCreatedBy { get; set; }
        public List<ReportData> ClientsHandledBy { get; set; }
    }


    public class ReportData
    {
        public ReportData(Client clients)
        {
            ClientId = clients.Id;
            ClientName = clients.ClientName;
            ClientCode = clients.Code;
            ClientPhone = clients.PhoneNumber;
            ClientStatus = clients.ClientStatus.GetAttribute<DisplayAttribute>().Name;
        }
        public string ClientId { get; set; }
        public int ClientCode { get; set; }
        public string ClientName { get; set; }
        public string ClientPhone { get; set; }
        public string ClientStatus { get; set; }
    }
}
