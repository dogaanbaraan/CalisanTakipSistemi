using CalisanTakip.Common.ConstantsModel;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CalisanTakip.Common.ViewModels
{
    public class WorkOrderVM : BaseVM
    {
        public DateTime CreateDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string AssignEmployeeId { get; set; }
        [MaxLength(750)]
        public string WorkOrderDescription { get; set; }
        public EnumWorkOrderStatus WorkOrderStatus { get; set; }

        public string WorkOrderStatusText { get; set; }

        public string PhotoPathText { get; set; }
        public IFormFile PhotoPath { get; set; }

        [Required]
        public double WorkOrderPoint { get; set; }
        [MaxLength(50)]

        public string AssignEmployeeName { get; set; }
        public string WorkOrderNumber { get; set; }

        [ForeignKey("AssignEmployeeId")]
        public EmployeeVM AssignEmployee { get; set; }
    }
}
