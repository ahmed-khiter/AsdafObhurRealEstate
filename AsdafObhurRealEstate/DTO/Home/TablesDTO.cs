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

        public int Code { get; set; }


        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public string Status { get; set; }

        public int FilesCreatedBy { get; set; }
        public int FilesAssignedTo { get; set; }

    }
}
