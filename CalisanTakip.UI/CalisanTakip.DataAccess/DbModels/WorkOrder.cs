using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CalisanTakip.DataAccess.DbModels
{
    public class WorkOrder : BaseEntity
    {
        public DateTime CreateDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string AssignEmployeeId { get; set; }
        [MaxLength(750)]
        public string WorkOrderDescription { get; set; }
        public int WorkOrderStatus { get; set; }
        public string PhotoPath { get; set; }
        public double WorkOrderPoint { get; set; }
        [MaxLength(50)]
        public string WorkOrderNumber { get; set; }

        [ForeignKey("AssignEmployeeId")]
        public Employee AssignEmployee { get; set; }
    }
}
