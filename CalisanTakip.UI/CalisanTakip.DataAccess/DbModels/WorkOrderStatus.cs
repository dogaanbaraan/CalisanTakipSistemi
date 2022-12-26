using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CalisanTakip.DataAccess.DbModels
{
    public class WorkOrderStatus : BaseEntity
    {
        [Required]
        public string WorkOrderStatusName { get; set; }
    }
}
