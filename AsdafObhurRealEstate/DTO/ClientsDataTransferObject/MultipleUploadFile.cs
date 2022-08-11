namespace AsdafObhurRealEstate.DTO.ClientsDataTransferObject
{
    public class MultipleUploadFile
    {
        public string ClientId { get; set; }

        public List<MultiMedia> Medias { get; set; }

    }

    public class MultiMedia
    {
        public string Description { get; set; }

        public IFormFile File { get; set; }
    }
}
