using System;

namespace dominio
{
    public class Vehiculo
    {
        public int Id {get; set;}
        public string Placa {get; set;}
        public string Modelo {get; set;}
        public string Servicio {get; set;}
        public Persona persona_ {get; set;}
        public TipoVehiculo tipo_vehiculo_ {get; set;}
        public Estilo estilo_ {get; set;}
        public Color color_ {get; set;}
    }
}