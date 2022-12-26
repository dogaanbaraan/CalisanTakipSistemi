using CalisanTakip.DataAccess.DbModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalisanTakip.DataAccess.DbContext
{
    public class CalisanTakipContext : IdentityDbContext
    {
        public CalisanTakipContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeLeaveAllocation> EmployeeLeaveAllocations{ get; set; }
        public DbSet<EmployeeLeaveRequest> EmployeeLeaveRequests { get; set; }
        public DbSet<EmployeeLeaveType> EmployeeLeaveTypes { get; set; }
        public DbSet<WorkOrderStatus> WorkOrdersStatuses { get; set; }
        public DbSet<WorkOrder> WorkOrders { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Employee>().Property(e => e.IsActive).HasDefaultValue(true);
            builder.Entity<Employee>().Property(e => e.IsAdmin).HasDefaultValue(false);
            base.OnModelCreating(builder);

           
        }
    }
}
