using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClientManagement_DataAccess.Migrations
{
    public partial class AddedNavigationPropertyToCompany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Clients_ClientId",
                table: "Companies");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "Companies",
                newName: "Client_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Companies_ClientId",
                table: "Companies",
                newName: "IX_Companies_Client_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Clients_Client_Id",
                table: "Companies",
                column: "Client_Id",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Clients_Client_Id",
                table: "Companies");

            migrationBuilder.RenameColumn(
                name: "Client_Id",
                table: "Companies",
                newName: "ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_Companies_Client_Id",
                table: "Companies",
                newName: "IX_Companies_ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Clients_ClientId",
                table: "Companies",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
