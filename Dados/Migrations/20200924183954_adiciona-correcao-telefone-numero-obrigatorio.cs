using Microsoft.EntityFrameworkCore.Migrations;

namespace Dados.Migrations
{
    public partial class adicionacorrecaotelefonenumeroobrigatorio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TelefoneDataModel_Cliente_ClienteDataModelId",
                table: "TelefoneDataModel");

            migrationBuilder.DropIndex(
                name: "IX_TelefoneDataModel_ClienteDataModelId",
                table: "TelefoneDataModel");

            migrationBuilder.DropColumn(
                name: "ClienteDataModelId",
                table: "TelefoneDataModel");

            migrationBuilder.AlterColumn<string>(
                name: "Numero",
                table: "TelefoneDataModel",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClienteID",
                table: "TelefoneDataModel",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TelefoneDataModel_ClienteID",
                table: "TelefoneDataModel",
                column: "ClienteID");

            migrationBuilder.AddForeignKey(
                name: "FK_TelefoneDataModel_Cliente_ClienteID",
                table: "TelefoneDataModel",
                column: "ClienteID",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TelefoneDataModel_Cliente_ClienteID",
                table: "TelefoneDataModel");

            migrationBuilder.DropIndex(
                name: "IX_TelefoneDataModel_ClienteID",
                table: "TelefoneDataModel");

            migrationBuilder.DropColumn(
                name: "ClienteID",
                table: "TelefoneDataModel");

            migrationBuilder.AlterColumn<string>(
                name: "Numero",
                table: "TelefoneDataModel",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 10);

            migrationBuilder.AddColumn<int>(
                name: "ClienteDataModelId",
                table: "TelefoneDataModel",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TelefoneDataModel_ClienteDataModelId",
                table: "TelefoneDataModel",
                column: "ClienteDataModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_TelefoneDataModel_Cliente_ClienteDataModelId",
                table: "TelefoneDataModel",
                column: "ClienteDataModelId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
