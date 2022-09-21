using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dominio
{
    public class Revision
    {
        [Key]
        public int RevisionId {get; set;}
        public DateTime Fecha {get; set;}
        public int Kilometraje {get; set;}
        public string Estado_vehiculo {get; set;}
        public DateTime Fecha_inicio {get; set;}
        public DateTime Fecha_fin {get; set;}
        public string Estado {get; set;}
        public string Sintomas {get; set;}

        [ForeignKey("Vehiculo")]
        public int VehiculoId {get;set;}
        public virtual Vehiculo vehiculo {get;set;}

        [ForeignKey("Tecnico")]
        public int TecnicoId {get;set;}
        public virtual Tecnico tecnico {get;set;}

        public RevOperaciones revOperaciones {get;set;}
        public RevRepuestos revRepuestos {get;set;}

    }
}