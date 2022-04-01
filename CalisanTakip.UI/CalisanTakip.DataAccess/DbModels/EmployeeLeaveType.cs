using System;
using System.Collections.Generic;
using System.Text;

namespace CalisanTakip.DataAccess.DbModels
{
    public class EmployeeLeaveType : BaseEntity
    {
        public string  Name { get; set; }
        public string DefaultDays { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsActive { get; set; }
    }
}
