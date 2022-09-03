using System;

namespace dominio
{
    public class Revision
    {
        public int Id {get; set;}
        public DateTime Fecha {get; set;}
        public int Kilometraje {get; set;}
        public string Estado_vehiculo {get; set;}
        public DateTime Fecha_inicio {get; set;}
        public DateTime Fecha_fin {get; set;}
        public string Estado {get; set;}
        public string Sintomas {get; set;}
        public Vehiculo vehiculo_ {get; set;}
        public Tecnico tecnico_ {get; set;}
    }
}