using Microsoft.EntityFrameworkCore.Migrations;

namespace persistencia.Migrations
{
    public partial class Inicial7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TecnicoId",
                table: "revision",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_revision_TecnicoId",
                table: "revision",
                column: "TecnicoId");

            migrationBuilder.AddForeignKey(
                name: "FK_revision_tecnico_TecnicoId",
                table: "revision",
                column: "TecnicoId",
                principalTable: "tecnico",
                principalColumn: "TecnicoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_revision_tecnico_TecnicoId",
                table: "revision");

            migrationBuilder.DropIndex(
                name: "IX_revision_TecnicoId",
                table: "revision");

            migrationBuilder.DropColumn(
                name: "TecnicoId",
                table: "revision");
        }
    }
}
