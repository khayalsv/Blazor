using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MudBlazorTest.Migrations
{
    public partial class abotrolesfs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Roles",
                newName: "RoleName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RoleName",
                table: "Roles",
                newName: "Name");
        }
    }
}
