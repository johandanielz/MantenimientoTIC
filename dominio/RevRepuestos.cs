using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dominio
{
    public class RevRepuestos
    {
      [Key]
      public int RevRepuestosId {get; set;}

      /*   [ForeignKey("Repuesto")]
        public int RepuestoId {get;set;}
        public virtual Repuesto repuesto {get;set;}

        [ForeignKey("Revision")]
        public int RevisionId {get;set;}
        public virtual Revision revision {get;set;} */
    }
}