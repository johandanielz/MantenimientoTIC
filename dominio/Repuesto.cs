using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dominio
{
    public class Repuesto
    {
        public int Id {get; set;}
        public string Referencia {get; set;}
        public string Producto {get; set;}
        public string Tipo {get; set;}
        public int Costo {get; set;}
        public int Precio {get; set;}
        public int Cantidad {get; set;}
        public bool Estado {get; set;}

        [ForeignKey("GrupoRepuesto")]
        public int GrupoRId {get;set;}

        public virtual GrupoRepuesto GrupoRepuesto {get;set;}
    }
}