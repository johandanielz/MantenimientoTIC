﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using persistencia;

namespace persistencia.Migrations
{
    [DbContext(typeof(AplicationsContext))]
    [Migration("20220918204115_Inicial5")]
    partial class Inicial5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("dominio.Color", b =>
                {
                    b.Property<int>("ColorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ColorId");

                    b.ToTable("color");
                });

            modelBuilder.Entity("dominio.Estilo", b =>
                {
                    b.Property<int>("EstiloId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EstiloId");

                    b.ToTable("estilo");
                });

            modelBuilder.Entity("dominio.GrupoRepuesto", b =>
                {
                    b.Property<int>("GrupoRepuestoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<string>("Grupo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GrupoRepuestoId");

                    b.ToTable("grupoRepuesto");
                });

            modelBuilder.Entity("dominio.Marca", b =>
                {
                    b.Property<int>("MarcaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MarcaId");

                    b.ToTable("marca");
                });

            modelBuilder.Entity("dominio.Operacion", b =>
                {
                    b.Property<int>("OperacionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<int>("Horas")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OperacionId");

                    b.ToTable("operacion");
                });

            modelBuilder.Entity("dominio.Persona", b =>
                {
                    b.Property<int>("PersonaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cedula")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Celular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Clasificacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoDocumento")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonaId");

                    b.ToTable("persona");
                });

            modelBuilder.Entity("dominio.Repuesto", b =>
                {
                    b.Property<int>("RepuestoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("Costo")
                        .HasColumnType("int");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<int>("GrupoRepuestoId")
                        .HasColumnType("int");

                    b.Property<int>("Precio")
                        .HasColumnType("int");

                    b.Property<string>("Producto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Referencia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RepuestoId");

                    b.HasIndex("GrupoRepuestoId");

                    b.ToTable("repuesto");
                });

            modelBuilder.Entity("dominio.RevOperaciones", b =>
                {
                    b.Property<int>("RevOperacionesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("OperacionId")
                        .HasColumnType("int");

                    b.Property<int>("RevisionId")
                        .HasColumnType("int");

                    b.HasKey("RevOperacionesId");

                    b.HasIndex("OperacionId")
                        .IsUnique();

                    b.HasIndex("RevisionId")
                        .IsUnique();

                    b.ToTable("revOperaciones");
                });

            modelBuilder.Entity("dominio.RevRepuestos", b =>
                {
                    b.Property<int>("RevRepuestosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("RepuestoId")
                        .HasColumnType("int");

                    b.Property<int>("RevisionId")
                        .HasColumnType("int");

                    b.HasKey("RevRepuestosId");

                    b.HasIndex("RepuestoId")
                        .IsUnique();

                    b.HasIndex("RevisionId")
                        .IsUnique();

                    b.ToTable("revRepuestos");
                });

            modelBuilder.Entity("dominio.Revision", b =>
                {
                    b.Property<int>("RevisionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado_vehiculo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Fecha_fin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Fecha_inicio")
                        .HasColumnType("datetime2");

                    b.Property<int>("Kilometraje")
                        .HasColumnType("int");

                    b.Property<string>("Sintomas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VehiculoId")
                        .HasColumnType("int");

                    b.HasKey("RevisionId");

                    b.HasIndex("VehiculoId");

                    b.ToTable("revision");
                });

            modelBuilder.Entity("dominio.Tecnico", b =>
                {
                    b.Property<int>("TecnicoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<int>("PersonaId")
                        .HasColumnType("int");

                    b.Property<int>("TipoVehiculoId")
                        .HasColumnType("int");

                    b.HasKey("TecnicoId");

                    b.HasIndex("PersonaId")
                        .IsUnique();

                    b.HasIndex("TipoVehiculoId");

                    b.ToTable("tecnico");
                });

            modelBuilder.Entity("dominio.TipoVehiculo", b =>
                {
                    b.Property<int>("TipoVehiculoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TipoVehiculoId");

                    b.ToTable("tipoVehiculo");
                });

            modelBuilder.Entity("dominio.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UsuarioId");

                    b.ToTable("usuario");
                });

            modelBuilder.Entity("dominio.Vehiculo", b =>
                {
                    b.Property<int>("VehiculoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ColorId")
                        .HasColumnType("int");

                    b.Property<int>("EstiloId")
                        .HasColumnType("int");

                    b.Property<int>("MarcaId")
                        .HasColumnType("int");

                    b.Property<string>("Modelo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonaId")
                        .HasColumnType("int");

                    b.Property<string>("Placa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Servicio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoVehiculoId")
                        .HasColumnType("int");

                    b.HasKey("VehiculoId");

                    b.HasIndex("ColorId")
                        .IsUnique();

                    b.HasIndex("EstiloId")
                        .IsUnique();

                    b.HasIndex("MarcaId")
                        .IsUnique();

                    b.HasIndex("PersonaId");

                    b.HasIndex("TipoVehiculoId")
                        .IsUnique();

                    b.ToTable("vehiculo");
                });

            modelBuilder.Entity("dominio.Repuesto", b =>
                {
                    b.HasOne("dominio.GrupoRepuesto", "grupoRepuesto")
                        .WithMany("repuesto")
                        .HasForeignKey("GrupoRepuestoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("grupoRepuesto");
                });

            modelBuilder.Entity("dominio.RevOperaciones", b =>
                {
                    b.HasOne("dominio.Operacion", "operacion")
                        .WithOne("revOperaciones")
                        .HasForeignKey("dominio.RevOperaciones", "OperacionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("dominio.Revision", "revision")
                        .WithOne("revOperaciones")
                        .HasForeignKey("dominio.RevOperaciones", "RevisionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("operacion");

                    b.Navigation("revision");
                });

            modelBuilder.Entity("dominio.RevRepuestos", b =>
                {
                    b.HasOne("dominio.Repuesto", "repuesto")
                        .WithOne("revRepuestos")
                        .HasForeignKey("dominio.RevRepuestos", "RepuestoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("dominio.Revision", "revision")
                        .WithOne("revRepuestos")
                        .HasForeignKey("dominio.RevRepuestos", "RevisionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("repuesto");

                    b.Navigation("revision");
                });

            modelBuilder.Entity("dominio.Revision", b =>
                {
                    b.HasOne("dominio.Vehiculo", "vehiculo")
                        .WithMany("revision")
                        .HasForeignKey("VehiculoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("vehiculo");
                });

            modelBuilder.Entity("dominio.Tecnico", b =>
                {
                    b.HasOne("dominio.Persona", "persona")
                        .WithOne("tecnico")
                        .HasForeignKey("dominio.Tecnico", "PersonaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("dominio.TipoVehiculo", "tipoVehiculo")
                        .WithMany("tecnico")
                        .HasForeignKey("TipoVehiculoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("persona");

                    b.Navigation("tipoVehiculo");
                });

            modelBuilder.Entity("dominio.Vehiculo", b =>
                {
                    b.HasOne("dominio.Color", "color")
                        .WithOne("vehiculo")
                        .HasForeignKey("dominio.Vehiculo", "ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("dominio.Estilo", "estilo")
                        .WithOne("vehiculo")
                        .HasForeignKey("dominio.Vehiculo", "EstiloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("dominio.Marca", "marca")
                        .WithOne("vehiculo")
                        .HasForeignKey("dominio.Vehiculo", "MarcaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("dominio.Persona", "persona")
                        .WithMany("vehiculo")
                        .HasForeignKey("PersonaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("dominio.TipoVehiculo", "tipoVehiculo")
                        .WithOne("vehiculo")
                        .HasForeignKey("dominio.Vehiculo", "TipoVehiculoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("color");

                    b.Navigation("estilo");

                    b.Navigation("marca");

                    b.Navigation("persona");

                    b.Navigation("tipoVehiculo");
                });

            modelBuilder.Entity("dominio.Color", b =>
                {
                    b.Navigation("vehiculo");
                });

            modelBuilder.Entity("dominio.Estilo", b =>
                {
                    b.Navigation("vehiculo");
                });

            modelBuilder.Entity("dominio.GrupoRepuesto", b =>
                {
                    b.Navigation("repuesto");
                });

            modelBuilder.Entity("dominio.Marca", b =>
                {
                    b.Navigation("vehiculo");
                });

            modelBuilder.Entity("dominio.Operacion", b =>
                {
                    b.Navigation("revOperaciones");
                });

            modelBuilder.Entity("dominio.Persona", b =>
                {
                    b.Navigation("tecnico");

                    b.Navigation("vehiculo");
                });

            modelBuilder.Entity("dominio.Repuesto", b =>
                {
                    b.Navigation("revRepuestos");
                });

            modelBuilder.Entity("dominio.Revision", b =>
                {
                    b.Navigation("revOperaciones");

                    b.Navigation("revRepuestos");
                });

            modelBuilder.Entity("dominio.TipoVehiculo", b =>
                {
                    b.Navigation("tecnico");

                    b.Navigation("vehiculo");
                });

            modelBuilder.Entity("dominio.Vehiculo", b =>
                {
                    b.Navigation("revision");
                });
#pragma warning restore 612, 618
        }
    }
}
