using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CalisanTakip.Common.ConstantsModel
{
    public enum EnumEmployeeLeaveRequestStatus
    {
        [Display(Name ="Onaya Gönderildi")]
        Send_Approved =1,
        [Display(Name = "Onaylandı")]
        Approved = 2,
        [Display(Name = "Reddedildi")]
        Rejected = 3,

    }
}
