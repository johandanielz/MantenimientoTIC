using System;

namespace dominio
{
    public class Repuesto
    {
        public int Repuesto_id {get; set;}
        public string Referencia {get; set;}
        public string Producto {get; set;}
        public string Tipo {get; set;}
        public int Costo {get; set;}
        public int Precio {get; set;}
        public int Cantidad {get; set;}
        public bool Estado {get; set;}
        public int Id_grupo {get; set;}
    }
}