using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CalisanTakip.Common.ViewModels
{
    public class EmployeeLeaveRequestVM : BaseVM
    {
        public int EmployeeLeaveTypeId { get; set; }

        public EmployeeLeaveTypeVM EmployeeLeaveType { get; set; }

        public string ApprovedEmployeeId { get; set; }

        public EmployeeVM ApprovedEmployee { get; set; }

        public string RequestingEmployeeId { get; set; }
        public EmployeeVM RequestingEmployee { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime DateRequested { get; set; }
        [Display(Name ="Talep Açıklama")]
        [MaxLength(300, ErrorMessage ="300 karakterden fazla değer girilemez.")]
        public string RequestComments { get; set; }
        public bool? Approved { get; set; }
        public bool Cancelled { get; set; }
    }
}
