using CalisanTakip.Common.ResultModels;
using CalisanTakip.Common.SessionOperations;
using CalisanTakip.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalisanTakip.BusinessEngine.Contracts
{
    public interface IEmployeeLeaveRequestBusinessEngine
    {
        Result<List<EmployeeLeaveRequestVM>> GetAllLeaveRequestByUserId(string userId);

        Result<EmployeeLeaveRequestVM> CreateEmployeeLeaveRequest(EmployeeLeaveRequestVM model, SessionContext user);

        Result<EmployeeLeaveRequestVM> EditEmployeeLeaveRequest(EmployeeLeaveRequestVM model, SessionContext user);
        Result<EmployeeLeaveRequestVM> GetAllLeaveRequestById(int id);

        Result<EmployeeLeaveRequestVM> RemoveEmployeeLeaveRequest(int id);

        Result<List<EmployeeLeaveRequestVM>> GetSendApprovedRequests();

        Result<bool> RejectEmployeeLeaveRequest (int id);
    }
}
