using System;

namespace dominio
{
    public class Operacion
    {
        public int Operacion_id {get; set;}
        public string Codigo {get; set;}
        public string Nombre {get; set;}
        public string Descripcion {get; set;}
        public int Horas {get; set;}
        public bool Estado {get; set;}
    }
}