using System;
/* using System.ComponentModel.DataAnnotations; */

namespace dominio
{
    public class Persona
    {
        public int Id {get; set;}
        /* [Required, StringLength(50)] */
        public string TipoDocumento {get; set;}
        /* [Required, StringLength(10)] */
        public string Cedula {get; set;}
        /* [Required, StringLength(50)] */
        public string Nombre {get; set;}
        /* [Required, StringLength(50)] */
        public string Apellido {get; set;}
        /* [Required, StringLength(10)] */
        public string Celular {get; set;}
        /* [Required, StringLength(50)] */
        public string Correo {get; set;}
        /* [Required, StringLength(50)] */
        public string Direccion {get; set;}
        /* [Required, StringLength(15)] */
        public string Clasificacion {get; set;}

        /* public string ingresar(){
            return "Ingresé al sistema";
        } */
    }
}
