using AsdafObhurRealEstate.Enums;
using Microsoft.AspNetCore.Identity;

namespace AsdafObhurRealEstate.Models
{
    public class BaseUser : IdentityUser
    {   
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string ProfilePic { get; set; }
        public AccountType AccountType { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }

        public int Code { get; set; }

        public string DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
