using System.ComponentModel.DataAnnotations;

namespace AsdafObhurRealEstate.DTO.ClientsDataTransferObject
{
    public class MultipleUploadFile
    {
        public string ClientId { get; set; }

        public List<MultiMedia> Medias { get; set; }

    }

    public class MultiMedia
    {
        [Required(ErrorMessage = "وصف اسم الفايل إجبارى")]
        [Display(Name = "وصف الفايل")]
        public string Description { get; set; }

        [Required(ErrorMessage = "يجب إرفاق الفايل")]
        public IFormFile File { get; set; }
    }
}
