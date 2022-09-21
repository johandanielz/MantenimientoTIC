using Microsoft.EntityFrameworkCore.Migrations;

namespace persistencia.Migrations
{
    public partial class Inicial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OperacionId",
                table: "revOperaciones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RevisionId",
                table: "revOperaciones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_revOperaciones_OperacionId",
                table: "revOperaciones",
                column: "OperacionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_revOperaciones_RevisionId",
                table: "revOperaciones",
                column: "RevisionId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_revOperaciones_operacion_OperacionId",
                table: "revOperaciones",
                column: "OperacionId",
                principalTable: "operacion",
                principalColumn: "OperacionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_revOperaciones_revision_RevisionId",
                table: "revOperaciones",
                column: "RevisionId",
                principalTable: "revision",
                principalColumn: "RevisionId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_revOperaciones_operacion_OperacionId",
                table: "revOperaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_revOperaciones_revision_RevisionId",
                table: "revOperaciones");

            migrationBuilder.DropIndex(
                name: "IX_revOperaciones_OperacionId",
                table: "revOperaciones");

            migrationBuilder.DropIndex(
                name: "IX_revOperaciones_RevisionId",
                table: "revOperaciones");

            migrationBuilder.DropColumn(
                name: "OperacionId",
                table: "revOperaciones");

            migrationBuilder.DropColumn(
                name: "RevisionId",
                table: "revOperaciones");
        }
    }
}
