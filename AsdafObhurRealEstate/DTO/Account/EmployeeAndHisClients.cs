using AsdafObhurRealEstate.Enums;

namespace AsdafObhurRealEstate.DTO.Account
{
    public class EmployeeAndHisClients
    {

        public string UserId { get; set; }

        public int EmployeeCode { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public List<ClientDetailsDto> ClientsWhoCreated { get; set; }
        public List<ClientDetailsDto> ClientsWhoHandled { get; set; }

    }
    public class ClientDetailsDto
    {
        public string ClientId { get; set; }

        public string ClientCode { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public StatusOfClient Status { get; set; }


    }
    
}
