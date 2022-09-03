using System;

namespace dominio
{
    public class Tecnico
    {
        public int Id {get; set;}
        public bool Estado {get; set;}
        public TipoVehiculo tipo_vehiculo_ {get; set;}
        public Persona persona_ {get; set;}
    }
}