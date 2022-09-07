using System;
using dominio;
using persistencia;

namespace consola
{
    public class hola
    {
        private static IRepositorioPersona _repo = new RepositorioPersona(new AppContext());
        static void Main(string[] args)
        {   
            var personas = _repo.GetAll();
            foreach (var persona in personas)
            {
                Console.WriteLine(persona.Nombre);
            }
        }
    }
}