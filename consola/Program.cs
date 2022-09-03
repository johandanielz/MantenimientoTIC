using System.Security.Permissions;
using System.IO.Pipes;
using System;
using dominio;

namespace consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.Nombre = "Johan";
            persona.Apellido = "Zuleta";
            Console.WriteLine(persona.Nombre + " " + persona.Apellido + " " + persona.ingresar());
        }
    }
}
