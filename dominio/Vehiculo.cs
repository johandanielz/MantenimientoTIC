using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dominio
{
    public class Vehiculo
    {
        [Key]
        public int VehiculoId {get; set;}
        public string Placa {get; set;}
        public string Modelo {get; set;}
        public string Servicio {get; set;}

        [ForeignKey("TipoVehiculo")]
        public int TipoVehiculoId {get;set;}
        public virtual TipoVehiculo tipoVehiculo {get;set;}

        [ForeignKey("Marca")]
        public int MarcaId {get;set;}
        public virtual Marca marca {get;set;}

        [ForeignKey("Estilo")]
        public int EstiloId {get;set;}
        public virtual Estilo estilo {get;set;}

        [ForeignKey("Persona")]
        public int PersonaId {get;set;}
        public virtual Persona persona {get;set;}

        [ForeignKey("Color")]
        public int ColorId {get;set;}
        public virtual Color color {get;set;}

       /*  public ICollection<Revision> revision { get; set; } */
    }
}