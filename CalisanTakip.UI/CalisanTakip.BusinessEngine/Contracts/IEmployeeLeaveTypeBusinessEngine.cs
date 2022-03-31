using CalisanTakip.Common.ResultModels;
using CalisanTakip.Common.ViewModels;
using CalisanTakip.DataAccess.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalisanTakip.BusinessEngine.Contracts
{
    public interface IEmployeeLeaveTypeBusinessEngine
    {
        Result<List<EmployeeLeaveTypeVM>> GetAllEmployeeLeaveType();
    }
}
