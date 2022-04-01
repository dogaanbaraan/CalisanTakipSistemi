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
        Result<EmployeeLeaveTypeVM> CreateEmployeeLeaveType(EmployeeLeaveTypeVM model);

        Result<EmployeeLeaveTypeVM> GetIdEmployeeLeaveType(int id);

        Result<EmployeeLeaveTypeVM> EditEmployeeLeaveType(EmployeeLeaveTypeVM model);

        Result<EmployeeLeaveTypeVM> RemoveEmployeeLeaveType(int id);
    }
}
