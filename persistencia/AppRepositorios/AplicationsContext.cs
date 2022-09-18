using System;
using dominio;
using Microsoft.EntityFrameworkCore;

namespace persistencia
{
    public class AplicationsContext : DbContext  
    {
        private const string connectionString = @"Data Source=LAPTOP-SOGI9E3P;Initial Catalog=MantenimientoTaller;Integrated Security=True;";

        public DbSet<Persona> persona {get; set;}
        public DbSet<Usuario> usuario {get; set;}
        public DbSet<TipoVehiculo> tipoVehiculo {get; set;}
        public DbSet<Vehiculo> vehiculo {get; set;}
        public DbSet<Tecnico> tecnico {get; set;}
        public DbSet<Revision> revision {get; set;}
        public DbSet<Operacion> operacion {get; set;}
        public DbSet<RevOperaciones> revOperaciones {get; set;}
        public DbSet<Repuesto> repuesto {get; set;}
        public DbSet<GrupoRepuesto> grupoRepuesto {get; set;}
        public DbSet<RevRepuestos> revRepuestos {get; set;} 
        public DbSet<Color> color {get;set;}
        public DbSet<Estilo> estilo {get;set;}
        public DbSet<Marca> marca {get;set;}

        public AplicationsContext(){}

        public AplicationsContext(DbContextOptions<AplicationsContext> options)
        :base(options)
    {
    }

     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(connectionString);
    }   
    }
}