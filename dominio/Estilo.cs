using System;

namespace dominio
{
    public class Estilo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool Estado { get; set; }
        public Marca marca_ { get; set; }   
    }
}