using System;

namespace dominio
{
    public class RevRepuestos
    {
        public int Id {get; set;}
        public Repuesto repuesto {get; set;}
        public Revision revision {get; set;}
    }
}