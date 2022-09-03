using Microsoft.EntityFrameworkCore.Migrations;

namespace persistencia.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id_color",
                table: "vehiculo");

            migrationBuilder.DropColumn(
                name: "Id_estilo",
                table: "vehiculo");

            migrationBuilder.DropColumn(
                name: "Id_persona",
                table: "vehiculo");

            migrationBuilder.DropColumn(
                name: "Id_tipo_vehiculo",
                table: "vehiculo");

            migrationBuilder.DropColumn(
                name: "Id_persona",
                table: "usuario");

            migrationBuilder.DropColumn(
                name: "Id_persona",
                table: "tecnico");

            migrationBuilder.DropColumn(
                name: "Id_tipo_vehiculo",
                table: "tecnico");

            migrationBuilder.DropColumn(
                name: "Id_repuesto",
                table: "revRespuestos");

            migrationBuilder.DropColumn(
                name: "Id_revision",
                table: "revRespuestos");

            migrationBuilder.DropColumn(
                name: "Id_operacion",
                table: "revOperaciones");

            migrationBuilder.DropColumn(
                name: "Id_revision",
                table: "revOperaciones");

            migrationBuilder.DropColumn(
                name: "Id_tecnico",
                table: "revision");

            migrationBuilder.DropColumn(
                name: "Id_vehiculo",
                table: "revision");

            migrationBuilder.DropColumn(
                name: "Id_grupo",
                table: "repuesto");

            migrationBuilder.DropColumn(
                name: "Id_marca",
                table: "estilo");

            migrationBuilder.RenameColumn(
                name: "grupo",
                table: "grupoRepuesto",
                newName: "Grupo");

            migrationBuilder.AddColumn<int>(
                name: "color_Id",
                table: "vehiculo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "estilo_Id",
                table: "vehiculo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "persona_Id",
                table: "vehiculo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tipo_vehiculo_Id",
                table: "vehiculo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "persona_Id",
                table: "usuario",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "persona_Id",
                table: "tecnico",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tipo_vehiculo_Id",
                table: "tecnico",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "repuesto_Id",
                table: "revRespuestos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "revision_Id",
                table: "revRespuestos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "operacion_Id",
                table: "revOperaciones",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "revision_Id",
                table: "revOperaciones",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tecnico_Id",
                table: "revision",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "vehiculo_Id",
                table: "revision",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "grupo_Id",
                table: "repuesto",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "marca_Id",
                table: "estilo",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_vehiculo_color_Id",
                table: "vehiculo",
                column: "color_Id");

            migrationBuilder.CreateIndex(
                name: "IX_vehiculo_estilo_Id",
                table: "vehiculo",
                column: "estilo_Id");

            migrationBuilder.CreateIndex(
                name: "IX_vehiculo_persona_Id",
                table: "vehiculo",
                column: "persona_Id");

            migrationBuilder.CreateIndex(
                name: "IX_vehiculo_tipo_vehiculo_Id",
                table: "vehiculo",
                column: "tipo_vehiculo_Id");

            migrationBuilder.CreateIndex(
                name: "IX_usuario_persona_Id",
                table: "usuario",
                column: "persona_Id");

            migrationBuilder.CreateIndex(
                name: "IX_tecnico_persona_Id",
                table: "tecnico",
                column: "persona_Id");

            migrationBuilder.CreateIndex(
                name: "IX_tecnico_tipo_vehiculo_Id",
                table: "tecnico",
                column: "tipo_vehiculo_Id");

            migrationBuilder.CreateIndex(
                name: "IX_revRespuestos_repuesto_Id",
                table: "revRespuestos",
                column: "repuesto_Id");

            migrationBuilder.CreateIndex(
                name: "IX_revRespuestos_revision_Id",
                table: "revRespuestos",
                column: "revision_Id");

            migrationBuilder.CreateIndex(
                name: "IX_revOperaciones_operacion_Id",
                table: "revOperaciones",
                column: "operacion_Id");

            migrationBuilder.CreateIndex(
                name: "IX_revOperaciones_revision_Id",
                table: "revOperaciones",
                column: "revision_Id");

            migrationBuilder.CreateIndex(
                name: "IX_revision_tecnico_Id",
                table: "revision",
                column: "tecnico_Id");

            migrationBuilder.CreateIndex(
                name: "IX_revision_vehiculo_Id",
                table: "revision",
                column: "vehiculo_Id");

            migrationBuilder.CreateIndex(
                name: "IX_repuesto_grupo_Id",
                table: "repuesto",
                column: "grupo_Id");

            migrationBuilder.CreateIndex(
                name: "IX_estilo_marca_Id",
                table: "estilo",
                column: "marca_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_estilo_marca_marca_Id",
                table: "estilo",
                column: "marca_Id",
                principalTable: "marca",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_repuesto_grupoRepuesto_grupo_Id",
                table: "repuesto",
                column: "grupo_Id",
                principalTable: "grupoRepuesto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_revision_tecnico_tecnico_Id",
                table: "revision",
                column: "tecnico_Id",
                principalTable: "tecnico",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_revision_vehiculo_vehiculo_Id",
                table: "revision",
                column: "vehiculo_Id",
                principalTable: "vehiculo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_revOperaciones_operacion_operacion_Id",
                table: "revOperaciones",
                column: "operacion_Id",
                principalTable: "operacion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_revOperaciones_revision_revision_Id",
                table: "revOperaciones",
                column: "revision_Id",
                principalTable: "revision",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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

            migrationBuilder.AddForeignKey(
                name: "FK_tecnico_persona_persona_Id",
                table: "tecnico",
                column: "persona_Id",
                principalTable: "persona",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tecnico_tipoVehiculo_tipo_vehiculo_Id",
                table: "tecnico",
                column: "tipo_vehiculo_Id",
                principalTable: "tipoVehiculo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_usuario_persona_persona_Id",
                table: "usuario",
                column: "persona_Id",
                principalTable: "persona",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_vehiculo_color_color_Id",
                table: "vehiculo",
                column: "color_Id",
                principalTable: "color",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_vehiculo_estilo_estilo_Id",
                table: "vehiculo",
                column: "estilo_Id",
                principalTable: "estilo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_vehiculo_persona_persona_Id",
                table: "vehiculo",
                column: "persona_Id",
                principalTable: "persona",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_vehiculo_tipoVehiculo_tipo_vehiculo_Id",
                table: "vehiculo",
                column: "tipo_vehiculo_Id",
                principalTable: "tipoVehiculo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_estilo_marca_marca_Id",
                table: "estilo");

            migrationBuilder.DropForeignKey(
                name: "FK_repuesto_grupoRepuesto_grupo_Id",
                table: "repuesto");

            migrationBuilder.DropForeignKey(
                name: "FK_revision_tecnico_tecnico_Id",
                table: "revision");

            migrationBuilder.DropForeignKey(
                name: "FK_revision_vehiculo_vehiculo_Id",
                table: "revision");

            migrationBuilder.DropForeignKey(
                name: "FK_revOperaciones_operacion_operacion_Id",
                table: "revOperaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_revOperaciones_revision_revision_Id",
                table: "revOperaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_revRespuestos_repuesto_repuesto_Id",
                table: "revRespuestos");

            migrationBuilder.DropForeignKey(
                name: "FK_revRespuestos_revision_revision_Id",
                table: "revRespuestos");

            migrationBuilder.DropForeignKey(
                name: "FK_tecnico_persona_persona_Id",
                table: "tecnico");

            migrationBuilder.DropForeignKey(
                name: "FK_tecnico_tipoVehiculo_tipo_vehiculo_Id",
                table: "tecnico");

            migrationBuilder.DropForeignKey(
                name: "FK_usuario_persona_persona_Id",
                table: "usuario");

            migrationBuilder.DropForeignKey(
                name: "FK_vehiculo_color_color_Id",
                table: "vehiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_vehiculo_estilo_estilo_Id",
                table: "vehiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_vehiculo_persona_persona_Id",
                table: "vehiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_vehiculo_tipoVehiculo_tipo_vehiculo_Id",
                table: "vehiculo");

            migrationBuilder.DropIndex(
                name: "IX_vehiculo_color_Id",
                table: "vehiculo");

            migrationBuilder.DropIndex(
                name: "IX_vehiculo_estilo_Id",
                table: "vehiculo");

            migrationBuilder.DropIndex(
                name: "IX_vehiculo_persona_Id",
                table: "vehiculo");

            migrationBuilder.DropIndex(
                name: "IX_vehiculo_tipo_vehiculo_Id",
                table: "vehiculo");

            migrationBuilder.DropIndex(
                name: "IX_usuario_persona_Id",
                table: "usuario");

            migrationBuilder.DropIndex(
                name: "IX_tecnico_persona_Id",
                table: "tecnico");

            migrationBuilder.DropIndex(
                name: "IX_tecnico_tipo_vehiculo_Id",
                table: "tecnico");

            migrationBuilder.DropIndex(
                name: "IX_revRespuestos_repuesto_Id",
                table: "revRespuestos");

            migrationBuilder.DropIndex(
                name: "IX_revRespuestos_revision_Id",
                table: "revRespuestos");

            migrationBuilder.DropIndex(
                name: "IX_revOperaciones_operacion_Id",
                table: "revOperaciones");

            migrationBuilder.DropIndex(
                name: "IX_revOperaciones_revision_Id",
                table: "revOperaciones");

            migrationBuilder.DropIndex(
                name: "IX_revision_tecnico_Id",
                table: "revision");

            migrationBuilder.DropIndex(
                name: "IX_revision_vehiculo_Id",
                table: "revision");

            migrationBuilder.DropIndex(
                name: "IX_repuesto_grupo_Id",
                table: "repuesto");

            migrationBuilder.DropIndex(
                name: "IX_estilo_marca_Id",
                table: "estilo");

            migrationBuilder.DropColumn(
                name: "color_Id",
                table: "vehiculo");

            migrationBuilder.DropColumn(
                name: "estilo_Id",
                table: "vehiculo");

            migrationBuilder.DropColumn(
                name: "persona_Id",
                table: "vehiculo");

            migrationBuilder.DropColumn(
                name: "tipo_vehiculo_Id",
                table: "vehiculo");

            migrationBuilder.DropColumn(
                name: "persona_Id",
                table: "usuario");

            migrationBuilder.DropColumn(
                name: "persona_Id",
                table: "tecnico");

            migrationBuilder.DropColumn(
                name: "tipo_vehiculo_Id",
                table: "tecnico");

            migrationBuilder.DropColumn(
                name: "repuesto_Id",
                table: "revRespuestos");

            migrationBuilder.DropColumn(
                name: "revision_Id",
                table: "revRespuestos");

            migrationBuilder.DropColumn(
                name: "operacion_Id",
                table: "revOperaciones");

            migrationBuilder.DropColumn(
                name: "revision_Id",
                table: "revOperaciones");

            migrationBuilder.DropColumn(
                name: "tecnico_Id",
                table: "revision");

            migrationBuilder.DropColumn(
                name: "vehiculo_Id",
                table: "revision");

            migrationBuilder.DropColumn(
                name: "grupo_Id",
                table: "repuesto");

            migrationBuilder.DropColumn(
                name: "marca_Id",
                table: "estilo");

            migrationBuilder.RenameColumn(
                name: "Grupo",
                table: "grupoRepuesto",
                newName: "grupo");

            migrationBuilder.AddColumn<int>(
                name: "Id_color",
                table: "vehiculo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id_estilo",
                table: "vehiculo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id_persona",
                table: "vehiculo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id_tipo_vehiculo",
                table: "vehiculo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id_persona",
                table: "usuario",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id_persona",
                table: "tecnico",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id_tipo_vehiculo",
                table: "tecnico",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id_repuesto",
                table: "revRespuestos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id_revision",
                table: "revRespuestos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id_operacion",
                table: "revOperaciones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id_revision",
                table: "revOperaciones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id_tecnico",
                table: "revision",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id_vehiculo",
                table: "revision",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id_grupo",
                table: "repuesto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id_marca",
                table: "estilo",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
