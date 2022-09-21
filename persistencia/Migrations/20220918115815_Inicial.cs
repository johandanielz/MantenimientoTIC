using Microsoft.EntityFrameworkCore.Migrations;

namespace persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GrupoRepuestoId",
                table: "repuesto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_repuesto_GrupoRepuestoId",
                table: "repuesto",
                column: "GrupoRepuestoId");

            migrationBuilder.AddForeignKey(
                name: "FK_repuesto_grupoRepuesto_GrupoRepuestoId",
                table: "repuesto",
                column: "GrupoRepuestoId",
                principalTable: "grupoRepuesto",
                principalColumn: "GrupoRepuestoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_repuesto_grupoRepuesto_GrupoRepuestoId",
                table: "repuesto");

            migrationBuilder.DropIndex(
                name: "IX_repuesto_GrupoRepuestoId",
                table: "repuesto");

            migrationBuilder.DropColumn(
                name: "GrupoRepuestoId",
                table: "repuesto");
        }
    }
}
