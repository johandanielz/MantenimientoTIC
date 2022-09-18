using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dominio
{
    public class Usuario
    {
        [Key]
        public int UsuarioId {get; set;}
        public string Rol {get; set;}
        public string User {get; set;}
        public string Password {get; set;}
        public bool Estado {get; set;}
        
    }
}