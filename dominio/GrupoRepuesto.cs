using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace dominio
{
    public class GrupoRepuesto
    {
        public int Id {get; set;}
        public string Grupo {get; set;}
        public bool Estado {get; set;}
        public ICollection<Repuesto> repuesto { get; set; }
    }
}