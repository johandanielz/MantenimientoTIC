using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace persistencia.Migrations
{
    public partial class Six : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "color",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_color", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "estilo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_estilo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "grupoRepuesto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Grupo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_grupoRepuesto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "marca",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_marca", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "operacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Horas = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_operacion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "persona",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoDocumento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cedula = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Celular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Clasificacion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_persona", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "repuesto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Referencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Producto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Costo = table.Column<int>(type: "int", nullable: false),
                    Precio = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_repuesto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "revision",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kilometraje = table.Column<int>(type: "int", nullable: false),
                    Estado_vehiculo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fecha_inicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha_fin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sintomas = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_revision", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "revOperaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_revOperaciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "revRepuestos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_revRepuestos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tipoVehiculo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipoVehiculo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tecnico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    PersonaId = table.Column<int>(type: "int", nullable: false),
                    TipoVehiculoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tecnico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tecnico_persona_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "persona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tecnico_tipoVehiculo_TipoVehiculoId",
                        column: x => x.TipoVehiculoId,
                        principalTable: "tipoVehiculo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "vehiculo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Placa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Servicio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoVehiculoId = table.Column<int>(type: "int", nullable: false),
                    MarcaId = table.Column<int>(type: "int", nullable: false),
                    EstiloId = table.Column<int>(type: "int", nullable: false),
                    PersonaId = table.Column<int>(type: "int", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehiculo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_vehiculo_color_ColorId",
                        column: x => x.ColorId,
                        principalTable: "color",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_vehiculo_estilo_EstiloId",
                        column: x => x.EstiloId,
                        principalTable: "estilo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_vehiculo_marca_MarcaId",
                        column: x => x.MarcaId,
                        principalTable: "marca",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_vehiculo_persona_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "persona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_vehiculo_tipoVehiculo_TipoVehiculoId",
                        column: x => x.TipoVehiculoId,
                        principalTable: "tipoVehiculo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tecnico_PersonaId",
                table: "tecnico",
                column: "PersonaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tecnico_TipoVehiculoId",
                table: "tecnico",
                column: "TipoVehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_vehiculo_ColorId",
                table: "vehiculo",
                column: "ColorId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_vehiculo_EstiloId",
                table: "vehiculo",
                column: "EstiloId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_vehiculo_MarcaId",
                table: "vehiculo",
                column: "MarcaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_vehiculo_PersonaId",
                table: "vehiculo",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_vehiculo_TipoVehiculoId",
                table: "vehiculo",
                column: "TipoVehiculoId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "grupoRepuesto");

            migrationBuilder.DropTable(
                name: "operacion");

            migrationBuilder.DropTable(
                name: "repuesto");

            migrationBuilder.DropTable(
                name: "revision");

            migrationBuilder.DropTable(
                name: "revOperaciones");

            migrationBuilder.DropTable(
                name: "revRepuestos");

            migrationBuilder.DropTable(
                name: "tecnico");

            migrationBuilder.DropTable(
                name: "usuario");

            migrationBuilder.DropTable(
                name: "vehiculo");

            migrationBuilder.DropTable(
                name: "color");

            migrationBuilder.DropTable(
                name: "estilo");

            migrationBuilder.DropTable(
                name: "marca");

            migrationBuilder.DropTable(
                name: "persona");

            migrationBuilder.DropTable(
                name: "tipoVehiculo");
        }
    }
}
