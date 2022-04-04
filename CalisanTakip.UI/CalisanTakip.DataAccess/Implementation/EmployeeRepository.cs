using CalisanTakip.DataAccess.Contracts;
using CalisanTakip.DataAccess.DbContext;
using CalisanTakip.DataAccess.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalisanTakip.DataAccess.Implementation
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        private readonly CalisanTakipContext _ctx;

        public EmployeeRepository(CalisanTakipContext ctx) : base(ctx)
        {
        }
    }
}
