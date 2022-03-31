using CalisanTakip.DataAccess.Contracts;
using CalisanTakip.DataAccess.DbContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalisanTakip.DataAccess.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CalisanTakipContext _ctx;
        public UnitOfWork(CalisanTakipContext ctx)
        {
            _ctx = ctx;
            employeeLeaveAllocation = new EmployeeLeaveAllocationRepository(_ctx);
            employeeLeaveRequest = new EmployeeLeaveRequestRepository(_ctx);
            employeeLeaveType = new EmployeeLeaveTypeRepository(_ctx);
        }

        public IEmployeeLeaveAllocation employeeLeaveAllocation { get; private set; }
        public IEmployeeLeaveRequestRepository employeeLeaveRequest { get; private set; }
        public IEmployeeLeaveTypeRepository employeeLeaveType { get; private set; }

        public void Dispose()
        {
            _ctx.Dispose();
        }

        public void Save()
        {
            _ctx.SaveChanges();        }
    }
}
