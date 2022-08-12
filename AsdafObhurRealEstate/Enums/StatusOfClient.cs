using System.ComponentModel.DataAnnotations;

namespace AsdafObhurRealEstate.Enums
{
    public enum StatusOfClient
    {
        [Display(Name ="جديد")]
        NewRequest = 1,

        [Display(Name ="تحت الإجراء")]
        UnderProgress = 2,

        [Display(Name ="انتهي")]
        Finished = 3 ,

        [Display(Name = "للإدارة المالية")]
        FinancialTransformation = 4 ,
    }
}
