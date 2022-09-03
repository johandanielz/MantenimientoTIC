using System;

namespace dominio
{
    public class Persona
    {
        public int Id {get; set;}
        public string Cedula {get; set;}
        public string Nombre {get; set;}
        public string Apellido {get; set;}
        public string Celular {get; set;}
        public string Correo {get; set;}
        public string Direccion {get; set;}
        public string Clasificacion {get; set;}

        public string ingresar(){
            return "Ingresé al sistema";
        }
    }
}
