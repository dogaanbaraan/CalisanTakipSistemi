using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CalisanTakip.Common.ViewModels
{
    public class EmployeeLeaveTypeVM : BaseVM
    {
        [Required]
         public string Name { get;protected set; }
        public string  DefaultDays { get; protected set; }
        public DateTime DateCreated { get; protected set; }

        public void SetEmployeeType(string name)
        {
            this.Name = name;
        }
    }

   
}
