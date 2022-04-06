using CalisanTakip.Common.ConstantsModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CalisanTakip.Common.ViewModels
{
    public class EmployeeLeaveRequestVM : BaseVM
    {
        [Required]
        public int EmployeeLeaveTypeId { get; set; }
        public string LeaveTypeText { get; set; }
        public EmployeeLeaveTypeVM EmployeeLeaveType { get; set; }

        public string ApprovedEmployeeId { get; set; }

        public EmployeeVM ApprovedEmployee { get; set; }

        public string ApprovedText { get; set; }

        public string RequestingEmployeeId { get; set; }
        public EmployeeVM RequestingEmployee { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        public DateTime DateRequested { get; set; }
        [Display(Name ="Talep Açıklama")]
        [MaxLength(300, ErrorMessage ="300 karakterden fazla değer girilemez.")]
        public string RequestComments { get; set; }
        public EnumEmployeeLeaveRequestStatus ApprovedStatus { get; set; }
        public bool Cancelled { get; set; }
    }
}
