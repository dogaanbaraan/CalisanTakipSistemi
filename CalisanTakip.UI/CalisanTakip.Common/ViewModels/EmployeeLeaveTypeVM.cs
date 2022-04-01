using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CalisanTakip.Common.ViewModels
{
    public class EmployeeLeaveTypeVM : BaseVM
    {
        [Required]
         public string Name { get; set; }
        public string  DefaultDays { get;  set; }
        public DateTime DateCreated { get;  set; }

        public bool IsActive { get; set; } = true;
        public void SetEmployeeType(string name)
        {
            this.Name = name;
        }
    }

   
}
