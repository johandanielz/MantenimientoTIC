using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dominio
{
    public class Tecnico
    {
        [Key]
        public int TecnicoId {get; set;}
        public bool Estado {get; set;}
        
        [ForeignKey("Persona")]
        public int PersonaId {get;set;}
        public virtual Persona persona {get;set;}

        [ForeignKey("TipoVehiculo")]
        public int TipoVehiculoId {get;set;}
        public virtual TipoVehiculo tipoVehiculo {get;set;}

        /* public ICollection<Revision> revision { get; set; } */
    }
}