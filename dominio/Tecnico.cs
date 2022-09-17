using System;

namespace dominio
{
    public class Tecnico
    {
        public int Id {get; set;}
        public bool Estado {get; set;}
        public TipoVehiculo tipo_vehiculo {get; set;}
        public Persona persona {get; set;}
    }
}