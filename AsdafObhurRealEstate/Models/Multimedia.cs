namespace AsdafObhurRealEstate.Models
{
    public class Multimedia : Entity
    {
        public string Description { get; set; }

        public string Path { get; set; }


        public string ClientId { get; set; }

        public Client Client { get; set; }
    }
}
