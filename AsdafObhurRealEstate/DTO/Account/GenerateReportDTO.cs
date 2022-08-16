using AsdafObhurRealEstate.Enums;
using AsdafObhurRealEstate.Models;

namespace AsdafObhurRealEstate.DTO.Account
{
    public class GenerateReportDTO
    {
        public string UserId { get; set; }

        public DateTime From { get; set; }

        public DateTime To { get; set; }

        public string BaseUrl { get; set; }

        public string EmployeeName { get; set; }

        public string EmployeeEmail { get; set; }

        public int EmployeeCode { get; set; }

        public string PhoneNumber { get; set; }

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
            ClientStatus = clients.ClientStatus;
        }
        public string ClientId { get; set; }
        public int ClientCode { get; set; }
        public string ClientName { get; set; }
        public string ClientPhone { get; set; }
        public StatusOfClient ClientStatus { get; set; }
    }
}
