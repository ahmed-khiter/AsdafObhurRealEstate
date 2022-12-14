using System.ComponentModel.DataAnnotations;

namespace AsdafObhurRealEstate.DTO.ClientsDataTransferObject
{
    public class DetailsClientDTO
    {
        public string ClientId { get; set; }

        [Display(Name = "اسم العمييل")]
        public string ClientName { get; set; }

        [Display(Name = "العنوان")]
        public string Address { get; set; }

        [Display(Name = "رقم التلفون")]
        public string PhoneNumber { get; set; }

        [Display(Name = "الفاتوره القديمه")]
        public string BillsFileOld { get; set; }

        [Display(Name ="تاريخ الانشاء")]
        public string CreatedAt { get; set; }


        [Display(Name ="ملاحظات")]
        public string Notes { get; set; }

        [Display(Name = "تحميل فاتورة جديده")]
        public IFormFile BillsFileNew { get; set; }

        [Display(Name = "تفاصيل احتياج العميل")]
        public string CustomerNeeded { get; set; }

        [Display(Name = " تم انشاء ملف بواسطة")]
        public string CreatedBy { get; set; }

        [Display(Name = "تم التعامل مع الملف بواسطة")]
        public string HandledBy { get; set; }

        public string Status { get; set; }


        public int ClientCode { get; set; }

        public List<OldOtherFile> OldOtherFiles { get; set; }
        public List<NewOtherFile> NewOtherFiles { get; set; }

    }

    public class OldOtherFile
    {
        public string OtherFileId { get; set; }
        public string Description { get; set; }
        public string FileOld { get; set; }
    }

    public class NewOtherFile
    {
        [Display(Name = "وصف الفايل")]
        public string Description { get; set; }

        [Display(Name = "اسم الفايل")]
        public IFormFile NewFile { get; set; }

    }
 
}
