using System;
using dominio;
using persistencia;

namespace consola
{
    public class Hola
    {
        private static IRepositorioPersona rpe = new RepositorioPersona(new AplicationsContext());
        private static IRepositorioColor rcl = new RepositorioColor(new AplicationsContext());
        private static IRepositorioMarca rma = new RepositorioMarca(new AplicationsContext());
        private static IRepositorioEstilo res = new RepositorioEstilo(new AplicationsContext());
        static void Main(string[] args)
        {   
            /* var personas = _repo.GetAll();
            foreach (var persona in personas)
            {
                Console.WriteLine(persona.Nombre);
            } */
            /* Color color = new Color();
            color.Nombre = "Rojo";
            color.Estado = true;
            rcl.Add(color);
            Console.WriteLine("Se agrego Correctamente"); */

            /* Marca marca = new Marca();
            marca.Nombre = "Lamborghini";
            marca.Estado = true;
            rma.Add(marca);
            Console.WriteLine("Se agrego Correctamente"); */
            /* var marcas = rma.Get(1);
            Console.WriteLine(marcas.id); 
            Estilo estilo = new Estilo();
            estilo.Nombre = "Deportivo";
            estilo.Estado = true;
            estilo.marca_ = marcas.id;
            res.Add(estilo);
            Console.WriteLine("Se agrego Correctamente"); */

            /* var estilos = res.GetAll();
            foreach (var estilo in estilos)
            {
                Console.WriteLine(estilo.Nombre);
            } */

            
        }
    }
}