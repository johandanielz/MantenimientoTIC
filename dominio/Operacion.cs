using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dominio
{
    public class Operacion
    {
        [Key]
        public int OperacionId {get; set;}
        public string Codigo {get; set;}
        public string Nombre {get; set;}
        public string Descripcion {get; set;}
        public int Horas {get; set;}
        public bool Estado {get; set;}

        public RevOperaciones revOperaciones {get;set;} 
    }
}