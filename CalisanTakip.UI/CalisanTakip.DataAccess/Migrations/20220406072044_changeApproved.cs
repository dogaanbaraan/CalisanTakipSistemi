using Microsoft.EntityFrameworkCore.Migrations;

namespace CalisanTakip.DataAccess.Migrations
{
    public partial class changeApproved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Approved",
                table: "EmployeeLeaveRequests",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Approved",
                table: "EmployeeLeaveRequests",
                type: "bit",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            
        }
    }
}
