using CalisanTakip.DataAccess.Contracts;
using CalisanTakip.DataAccess.DbContext;
using CalisanTakip.DataAccess.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalisanTakip.DataAccess.Implementation
{
    public class EmployeeLeaveTypeRepository : Repository<EmployeeLeaveType>, IEmployeeLeaveTypeRepository
    {
        private readonly CalisanTakipContext _ctx;
        public EmployeeLeaveTypeRepository(CalisanTakipContext ctx) : base(ctx) 
        {
            _ctx = ctx;
        }

    }
}
