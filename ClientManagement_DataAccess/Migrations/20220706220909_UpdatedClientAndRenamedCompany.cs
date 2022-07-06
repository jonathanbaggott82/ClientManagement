using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClientManagement_DataAccess.Migrations
{
    public partial class UpdatedClientAndRenamedCompany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobTitle",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Salary",
                table: "Clients");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "Companies",
                newName: "DepartmentId");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Clients",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Clients",
                newName: "Industry");

            migrationBuilder.RenameColumn(
                name: "DateOfBirth",
                table: "Clients",
                newName: "Founded");

            migrationBuilder.AddColumn<string>(
                name: "Headquarters",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "NumLocations",
                table: "Clients",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Headquarters",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "NumLocations",
                table: "Clients");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Companies",
                newName: "CompanyId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Clients",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Industry",
                table: "Clients",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "Founded",
                table: "Clients",
                newName: "DateOfBirth");

            migrationBuilder.AddColumn<string>(
                name: "JobTitle",
                table: "Clients",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Salary",
                table: "Clients",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
