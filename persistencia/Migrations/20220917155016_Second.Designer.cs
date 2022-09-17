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
    [Migration("20220917155016_Second")]
    partial class Second
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
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("color");
                });

            modelBuilder.Entity("dominio.Estilo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("estilo");
                });

            modelBuilder.Entity("dominio.GrupoRepuesto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<string>("Grupo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("grupoRepuesto");
                });

            modelBuilder.Entity("dominio.Marca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("marca");
                });

            modelBuilder.Entity("dominio.Operacion", b =>
                {
                    b.Property<int>("Id")
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

                    b.HasKey("Id");

                    b.ToTable("operacion");
                });

            modelBuilder.Entity("dominio.Persona", b =>
                {
                    b.Property<int>("Id")
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

                    b.HasKey("Id");

                    b.ToTable("persona");
                });

            modelBuilder.Entity("dominio.Repuesto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("Costo")
                        .HasColumnType("int");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<int>("GrupoRId")
                        .HasColumnType("int");

                    b.Property<int>("Precio")
                        .HasColumnType("int");

                    b.Property<string>("Producto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Referencia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GrupoRId");

                    b.ToTable("repuesto");
                });

            modelBuilder.Entity("dominio.RevOperaciones", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("operacionId")
                        .HasColumnType("int");

                    b.Property<int?>("revisionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("operacionId");

                    b.HasIndex("revisionId");

                    b.ToTable("revOperaciones");
                });

            modelBuilder.Entity("dominio.RevRepuestos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("repuestoId")
                        .HasColumnType("int");

                    b.Property<int?>("revisionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("repuestoId");

                    b.HasIndex("revisionId");

                    b.ToTable("revRepuestos");
                });

            modelBuilder.Entity("dominio.Revision", b =>
                {
                    b.Property<int>("Id")
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

                    b.Property<int?>("tecnicoId")
                        .HasColumnType("int");

                    b.Property<int?>("vehiculoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("tecnicoId");

                    b.HasIndex("vehiculoId");

                    b.ToTable("revision");
                });

            modelBuilder.Entity("dominio.Tecnico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<int?>("personaId")
                        .HasColumnType("int");

                    b.Property<int?>("tipo_vehiculoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("personaId");

                    b.HasIndex("tipo_vehiculoId");

                    b.ToTable("tecnico");
                });

            modelBuilder.Entity("dominio.TipoVehiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("tipoVehiculo");
                });

            modelBuilder.Entity("dominio.Usuario", b =>
                {
                    b.Property<int>("Id")
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

                    b.Property<int?>("personaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("personaId");

                    b.ToTable("usuario");
                });

            modelBuilder.Entity("dominio.Vehiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("EstiloId")
                        .HasColumnType("int");

                    b.Property<int>("MarcaId")
                        .HasColumnType("int");

                    b.Property<string>("Modelo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PersonaId")
                        .HasColumnType("int");

                    b.Property<string>("Placa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Servicio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoVehiculoId")
                        .HasColumnType("int");

                    b.Property<int?>("colorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EstiloId")
                        .IsUnique();

                    b.HasIndex("MarcaId")
                        .IsUnique();

                    b.HasIndex("PersonaId");

                    b.HasIndex("TipoVehiculoId")
                        .IsUnique();

                    b.HasIndex("colorId");

                    b.ToTable("vehiculo");
                });

            modelBuilder.Entity("dominio.Repuesto", b =>
                {
                    b.HasOne("dominio.GrupoRepuesto", "GrupoRepuesto")
                        .WithMany("repuesto")
                        .HasForeignKey("GrupoRId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GrupoRepuesto");
                });

            modelBuilder.Entity("dominio.RevOperaciones", b =>
                {
                    b.HasOne("dominio.Operacion", "operacion")
                        .WithMany()
                        .HasForeignKey("operacionId");

                    b.HasOne("dominio.Revision", "revision")
                        .WithMany()
                        .HasForeignKey("revisionId");

                    b.Navigation("operacion");

                    b.Navigation("revision");
                });

            modelBuilder.Entity("dominio.RevRepuestos", b =>
                {
                    b.HasOne("dominio.Repuesto", "repuesto")
                        .WithMany()
                        .HasForeignKey("repuestoId");

                    b.HasOne("dominio.Revision", "revision")
                        .WithMany()
                        .HasForeignKey("revisionId");

                    b.Navigation("repuesto");

                    b.Navigation("revision");
                });

            modelBuilder.Entity("dominio.Revision", b =>
                {
                    b.HasOne("dominio.Tecnico", "tecnico")
                        .WithMany()
                        .HasForeignKey("tecnicoId");

                    b.HasOne("dominio.Vehiculo", "vehiculo")
                        .WithMany()
                        .HasForeignKey("vehiculoId");

                    b.Navigation("tecnico");

                    b.Navigation("vehiculo");
                });

            modelBuilder.Entity("dominio.Tecnico", b =>
                {
                    b.HasOne("dominio.Persona", "persona")
                        .WithMany()
                        .HasForeignKey("personaId");

                    b.HasOne("dominio.TipoVehiculo", "tipo_vehiculo")
                        .WithMany()
                        .HasForeignKey("tipo_vehiculoId");

                    b.Navigation("persona");

                    b.Navigation("tipo_vehiculo");
                });

            modelBuilder.Entity("dominio.Usuario", b =>
                {
                    b.HasOne("dominio.Persona", "persona")
                        .WithMany()
                        .HasForeignKey("personaId");

                    b.Navigation("persona");
                });

            modelBuilder.Entity("dominio.Vehiculo", b =>
                {
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

                    b.HasOne("dominio.Persona", null)
                        .WithMany("vehiculo")
                        .HasForeignKey("PersonaId");

                    b.HasOne("dominio.TipoVehiculo", "tipoVehiculo")
                        .WithOne("vehiculo")
                        .HasForeignKey("dominio.Vehiculo", "TipoVehiculoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("dominio.Color", "color")
                        .WithMany()
                        .HasForeignKey("colorId");

                    b.Navigation("color");

                    b.Navigation("estilo");

                    b.Navigation("marca");

                    b.Navigation("tipoVehiculo");
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

            modelBuilder.Entity("dominio.Persona", b =>
                {
                    b.Navigation("vehiculo");
                });

            modelBuilder.Entity("dominio.TipoVehiculo", b =>
                {
                    b.Navigation("vehiculo");
                });
#pragma warning restore 612, 618
        }
    }
}