using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StateApprove.Migrations
{
    public partial class adddbb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BaseCompanyId",
                table: "Companies",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BaseCompanies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseCompanies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BaseCompanies_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Companies_BaseCompanyId",
                table: "Companies",
                column: "BaseCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseCompanies_CompanyId",
                table: "BaseCompanies",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_BaseCompanies_BaseCompanyId",
                table: "Companies",
                column: "BaseCompanyId",
                principalTable: "BaseCompanies",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_BaseCompanies_BaseCompanyId",
                table: "Companies");

            migrationBuilder.DropTable(
                name: "BaseCompanies");

            migrationBuilder.DropIndex(
                name: "IX_Companies_BaseCompanyId",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "BaseCompanyId",
                table: "Companies");
        }
    }
}
