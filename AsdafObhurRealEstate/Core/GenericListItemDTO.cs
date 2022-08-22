using AsdafObhurRealEstate.Helpers;
using AsdafObhurRealEstate.Models;
using System.ComponentModel.DataAnnotations;

namespace AsdafObhurRealEstate.Core
{
    public class GenericListItemDTO
    {

        public GenericListItemDTO()
        {
        }
        
        public GenericListItemDTO(Client client)
        {
            this.Id = client.Id;
            Code = client.Code ;
            Name = client.ClientName ;
            PhoneNumber = client.PhoneNumber ;
            Status = client.ClientStatus.GetAttribute<DisplayAttribute>().Name;
            CreateAt = client.CreatedAt ;
        }

        public GenericListItemDTO(BaseUser user)
        {
            this.Id = user.Id;
            Code = user.Code;
            Name = $"{user.FirstName} {user.LastName}";
            PhoneNumber = user.PhoneNumber;
            CreateAt = user.CreatedAt;
        }


        public string Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Status { get; set; }
        public DateTime CreateAt { get; set; }
    }


}
