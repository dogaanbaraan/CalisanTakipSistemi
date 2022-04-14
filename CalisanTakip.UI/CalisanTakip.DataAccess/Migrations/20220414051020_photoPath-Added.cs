using Microsoft.EntityFrameworkCore.Migrations;

namespace CalisanTakip.DataAccess.Migrations
{
    public partial class photoPathAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhotoPath",
                table: "WorkOrders",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoPath",
                table: "WorkOrders");
        }
    }
}
