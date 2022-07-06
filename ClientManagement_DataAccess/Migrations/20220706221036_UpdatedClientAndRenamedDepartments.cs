using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClientManagement_DataAccess.Migrations
{
    public partial class UpdatedClientAndRenamedDepartments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Clients_Client_Id",
                table: "Companies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Companies",
                table: "Companies");

            migrationBuilder.RenameTable(
                name: "Companies",
                newName: "Departments");

            migrationBuilder.RenameIndex(
                name: "IX_Companies_Client_Id",
                table: "Departments",
                newName: "IX_Departments_Client_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departments",
                table: "Departments",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Clients_Client_Id",
                table: "Departments",
                column: "Client_Id",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Clients_Client_Id",
                table: "Departments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departments",
                table: "Departments");

            migrationBuilder.RenameTable(
                name: "Departments",
                newName: "Companies");

            migrationBuilder.RenameIndex(
                name: "IX_Departments_Client_Id",
                table: "Companies",
                newName: "IX_Companies_Client_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Companies",
                table: "Companies",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Clients_Client_Id",
                table: "Companies",
                column: "Client_Id",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
