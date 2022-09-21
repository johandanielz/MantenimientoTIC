using Microsoft.EntityFrameworkCore.Migrations;

namespace persistencia.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VehiculoId",
                table: "revision",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_revision_VehiculoId",
                table: "revision",
                column: "VehiculoId");

            migrationBuilder.AddForeignKey(
                name: "FK_revision_vehiculo_VehiculoId",
                table: "revision",
                column: "VehiculoId",
                principalTable: "vehiculo",
                principalColumn: "VehiculoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_revision_vehiculo_VehiculoId",
                table: "revision");

            migrationBuilder.DropIndex(
                name: "IX_revision_VehiculoId",
                table: "revision");

            migrationBuilder.DropColumn(
                name: "VehiculoId",
                table: "revision");
        }
    }
}
