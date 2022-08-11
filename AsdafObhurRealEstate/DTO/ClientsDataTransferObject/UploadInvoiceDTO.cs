namespace AsdafObhurRealEstate.DTO.ClientsDataTransferObject
{
    public class UploadInvoiceDTO
    {

        public string ClientId { get; set; }

        public string  FileName { get; set; }

        public IFormFile File { get; set; }
    }
}
