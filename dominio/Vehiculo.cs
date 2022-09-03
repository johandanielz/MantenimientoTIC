using System;

namespace dominio
{
    public class Vehiculo
    {
        public int Id {get; set;}
        public string Placa {get; set;}
        public string Modelo {get; set;}
        public string Servicio {get; set;}
        public int Id_persona {get; set;}
        public int Id_tipo_vehiculo {get; set;}
        public int Id_estilo {get; set;}
        public int Id_color {get; set;}
    }
}