using System.ComponentModel.DataAnnotations;

namespace AsdafObhurRealEstate.Models
{
    public class Department : Entity
    {
        [Required(AllowEmptyStrings = false, ErrorMessage ="اسم القسم إجبارى")]
        public string Name { get; set; }

        public ICollection<BaseUser> Users { get; set; }

    }
}
