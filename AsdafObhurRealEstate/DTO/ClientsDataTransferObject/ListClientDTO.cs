using AsdafObhurRealEstate.Enums;

namespace AsdafObhurRealEstate.DTO.ClientsDataTransferObject
{
    public class ListClientDTO
    {
        public string Id { get; set; }
        public string ClientName { get; set; }
        public string PhoneNumber { get; set; }

        public string Status { get; set; }
        public int Code { get; set; }
        public DateTime CreateAt { get; set; }

        public int TotalCount { get; set; }


    }

}
