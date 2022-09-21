using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dominio 
{
    public class RevOperaciones
    {
        [Key]
        public int RevOperacionesId {get; set;}

        [ForeignKey("Operacion")]
        public int OperacionId {get;set;}
        public virtual Operacion operacion {get;set;}

        [ForeignKey("Revision")]
        public int RevisionId {get;set;}
        public virtual Revision revision {get;set;}
        
    }
}