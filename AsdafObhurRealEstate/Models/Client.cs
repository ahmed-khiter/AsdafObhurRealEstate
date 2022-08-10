﻿namespace AsdafObhurRealEstate.Models
{
    public class Client : Entity
    {
        public string Code { get; set; }

        public string ClientName { get; set; }

        public string PhoneNumber { get; set; }

        public string BillsFile { get; set; }

        public string BaseUserId { get; set; }
        public BaseUser BaseUser { get; set; }

        public string DepartmentId { get; set; }
        public Department Department { get; set; }

    }
}
