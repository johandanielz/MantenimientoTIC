using Microsoft.EntityFrameworkCore.Migrations;

namespace persistencia.Migrations
{
    public partial class Seven : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "vehiculo",
                newName: "VehiculoId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "usuario",
                newName: "UsuarioId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tipoVehiculo",
                newName: "TipoVehiculoId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tecnico",
                newName: "TecnicoId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "revRepuestos",
                newName: "RevRepuestosId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "revOperaciones",
                newName: "RevOperacionesId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "revision",
                newName: "RevisionId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "repuesto",
                newName: "RepuestoId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "persona",
                newName: "PersonaId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "operacion",
                newName: "OperacionId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "marca",
                newName: "MarcaId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "grupoRepuesto",
                newName: "GrupoRepuestoId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "estilo",
                newName: "EstiloId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "color",
                newName: "ColorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VehiculoId",
                table: "vehiculo",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "usuario",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "TipoVehiculoId",
                table: "tipoVehiculo",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "TecnicoId",
                table: "tecnico",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "RevRepuestosId",
                table: "revRepuestos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "RevOperacionesId",
                table: "revOperaciones",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "RevisionId",
                table: "revision",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "RepuestoId",
                table: "repuesto",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "PersonaId",
                table: "persona",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "OperacionId",
                table: "operacion",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "MarcaId",
                table: "marca",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "GrupoRepuestoId",
                table: "grupoRepuesto",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "EstiloId",
                table: "estilo",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ColorId",
                table: "color",
                newName: "Id");
        }
    }
}
