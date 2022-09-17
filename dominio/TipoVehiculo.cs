using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dominio
{
    public class TipoVehiculo
    {
        public int Id {get; set;}
        public string Tipo {get; set;}
        public string Descripcion {get; set;}
        public bool Estado {get; set;}
        public Vehiculo vehiculo {get; set;}
    }
}