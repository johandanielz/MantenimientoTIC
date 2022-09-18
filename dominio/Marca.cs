using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dominio
{
    public class Marca
    {
        [Key]
        public int MarcaId { get; set;}
        public string Nombre { get; set; }
        public bool Estado { get; set; }
        public Vehiculo vehiculo {get; set;}
    }
}