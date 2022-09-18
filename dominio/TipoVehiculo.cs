using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dominio
{
    public class TipoVehiculo
    {
        [Key]
        public int TipoVehiculoId {get; set;}
        public string Tipo {get; set;}
        public string Descripcion {get; set;}
        public bool Estado {get; set;}
        public Vehiculo vehiculo {get; set;}

        public ICollection<Tecnico> tecnico { get; set; }
    }
}