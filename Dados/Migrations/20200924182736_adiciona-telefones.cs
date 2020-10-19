using Microsoft.EntityFrameworkCore.Migrations;

namespace Dados.Migrations
{
    public partial class adicionatelefones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "Cliente");

            migrationBuilder.CreateTable(
                name: "TelefoneDataModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero = table.Column<string>(nullable: true),
                    Tipo = table.Column<string>(nullable: true),
                    ClienteDataModelId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TelefoneDataModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TelefoneDataModel_Cliente_ClienteDataModelId",
                        column: x => x.ClienteDataModelId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TelefoneDataModel_ClienteDataModelId",
                table: "TelefoneDataModel",
                column: "ClienteDataModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TelefoneDataModel");

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
