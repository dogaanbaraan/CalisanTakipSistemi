using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CalisanTakip.Common.ConstantsModel
{
    public enum EnumWorkOrderStatus
    {
        [Display(Name ="İş Emri Oluşturuldu")]
        WorkOrder_Created = 1,

        [Display(Name ="Atandı")]
        Assigned = 2,
        [Display(Name ="Undertake")]
        Undertake = 3,
        [Display(Name ="Kapatıldı")]
        Closed = 4,
    }
}
