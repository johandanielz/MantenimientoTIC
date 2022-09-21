using Microsoft.EntityFrameworkCore.Migrations;

namespace persistencia.Migrations
{
    public partial class Inicial5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RepuestoId",
                table: "revRepuestos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RevisionId",
                table: "revRepuestos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_revRepuestos_RepuestoId",
                table: "revRepuestos",
                column: "RepuestoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_revRepuestos_RevisionId",
                table: "revRepuestos",
                column: "RevisionId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_revRepuestos_repuesto_RepuestoId",
                table: "revRepuestos",
                column: "RepuestoId",
                principalTable: "repuesto",
                principalColumn: "RepuestoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_revRepuestos_revision_RevisionId",
                table: "revRepuestos",
                column: "RevisionId",
                principalTable: "revision",
                principalColumn: "RevisionId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_revRepuestos_repuesto_RepuestoId",
                table: "revRepuestos");

            migrationBuilder.DropForeignKey(
                name: "FK_revRepuestos_revision_RevisionId",
                table: "revRepuestos");

            migrationBuilder.DropIndex(
                name: "IX_revRepuestos_RepuestoId",
                table: "revRepuestos");

            migrationBuilder.DropIndex(
                name: "IX_revRepuestos_RevisionId",
                table: "revRepuestos");

            migrationBuilder.DropColumn(
                name: "RepuestoId",
                table: "revRepuestos");

            migrationBuilder.DropColumn(
                name: "RevisionId",
                table: "revRepuestos");
        }
    }
}
