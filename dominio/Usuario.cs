using System;

namespace dominio
{
    public class Usuario
    {
        public int Id {get; set;}
        public string Rol {get; set;}
        public string User {get; set;}
        public string Password {get; set;}
        public bool Estado {get; set;}
        public Persona persona_ {get; set;}
    }
}