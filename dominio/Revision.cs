using System;

namespace dominio
{
    public class Revision
    {
        public int Revision_id {get; set;}
        public DateTime Fecha {get; set;}
        public int Kilometraje {get; set;}
        public string Estado_vehiculo {get; set;}
        public DateTime Fecha_inicio {get; set;}
        public DateTime Fecha_fin {get; set;}
        public string Estado {get; set;}
        public string Sintomas {get; set;}
        public int Id_vehiculo {get; set;}
        public int Id_tecnico {get; set;}
    }
}