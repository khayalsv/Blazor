using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StateApprove.Migrations
{
    public partial class adddbnew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BaseCompanies_Companies_CompanyId",
                table: "BaseCompanies");

            migrationBuilder.DropIndex(
                name: "IX_BaseCompanies_CompanyId",
                table: "BaseCompanies");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "BaseCompanies");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "BaseCompanies",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BaseCompanies_CompanyId",
                table: "BaseCompanies",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_BaseCompanies_Companies_CompanyId",
                table: "BaseCompanies",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id");
        }
    }
}
