using Microsoft.EntityFrameworkCore.Migrations;

namespace persistencia.Migrations
{
    public partial class tercerPrueba : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_revRespuestos_repuesto_repuesto_Id",
                table: "revRespuestos");

            migrationBuilder.DropForeignKey(
                name: "FK_revRespuestos_revision_revision_Id",
                table: "revRespuestos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_revRespuestos",
                table: "revRespuestos");

            migrationBuilder.RenameTable(
                name: "revRespuestos",
                newName: "revRepuestos");

            migrationBuilder.RenameColumn(
                name: "Descricion",
                table: "tipoVehiculo",
                newName: "Descripcion");

            migrationBuilder.RenameIndex(
                name: "IX_revRespuestos_revision_Id",
                table: "revRepuestos",
                newName: "IX_revRepuestos_revision_Id");

            migrationBuilder.RenameIndex(
                name: "IX_revRespuestos_repuesto_Id",
                table: "revRepuestos",
                newName: "IX_revRepuestos_repuesto_Id");

            migrationBuilder.AddColumn<string>(
                name: "TipoDocumento",
                table: "persona",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_revRepuestos",
                table: "revRepuestos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_revRepuestos_repuesto_repuesto_Id",
                table: "revRepuestos",
                column: "repuesto_Id",
                principalTable: "repuesto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_revRepuestos_revision_revision_Id",
                table: "revRepuestos",
                column: "revision_Id",
                principalTable: "revision",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_revRepuestos_repuesto_repuesto_Id",
                table: "revRepuestos");

            migrationBuilder.DropForeignKey(
                name: "FK_revRepuestos_revision_revision_Id",
                table: "revRepuestos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_revRepuestos",
                table: "revRepuestos");

            migrationBuilder.DropColumn(
                name: "TipoDocumento",
                table: "persona");

            migrationBuilder.RenameTable(
                name: "revRepuestos",
                newName: "revRespuestos");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "tipoVehiculo",
                newName: "Descricion");

            migrationBuilder.RenameIndex(
                name: "IX_revRepuestos_revision_Id",
                table: "revRespuestos",
                newName: "IX_revRespuestos_revision_Id");

            migrationBuilder.RenameIndex(
                name: "IX_revRepuestos_repuesto_Id",
                table: "revRespuestos",
                newName: "IX_revRespuestos_repuesto_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_revRespuestos",
                table: "revRespuestos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_revRespuestos_repuesto_repuesto_Id",
                table: "revRespuestos",
                column: "repuesto_Id",
                principalTable: "repuesto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_revRespuestos_revision_revision_Id",
                table: "revRespuestos",
                column: "revision_Id",
                principalTable: "revision",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
