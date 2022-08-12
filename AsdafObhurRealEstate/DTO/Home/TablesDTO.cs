using AsdafObhurRealEstate.Enums;

namespace AsdafObhurRealEstate.DTO.Home
{
    public class TablesDTO
    {
        public List<EmployeeAndClient> Employees { get; set; }
        public List<EmployeeAndClient> Clients { get; set; }

    }

    public class EmployeeAndClient
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public StatusOfClient Status { get; set; }

    }
}
