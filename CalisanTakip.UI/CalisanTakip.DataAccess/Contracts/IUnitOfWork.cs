using System;
using System.Collections.Generic;
using System.Text;

namespace CalisanTakip.DataAccess.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        IEmployeeLeaveAllocation employeeLeaveAllocation { get;}
        IEmployeeLeaveRequestRepository employeeLeaveRequest { get; }
        IEmployeeLeaveTypeRepository employeeLeaveType { get;}
        IEmployeeRepository employeeRepository { get; }
        IWorkOrderRepository workOrderRepository { get; }
        void Save();
    }
}
