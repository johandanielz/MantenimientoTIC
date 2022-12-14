using System.Collections.Generic;
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
        private static IRepositorioOperacion rop = new RepositorioOperacion(new AplicationsContext());
        private static IRepositorioGrupoRepuesto rgr = new RepositorioGrupoRepuesto(new AplicationsContext());
        private static IRepositorioTipoVehiculo rtv = new RepositorioTipoVehiculo(new AplicationsContext());
        private static IRepositorioRepuesto rr = new RepositorioRepuesto(new AplicationsContext());
        static void Main(string[] args)
        {   
            /* var personas = _repo.GetAll();
            foreach (var persona in personas)
            {
                Console.WriteLine(persona.Nombre);
            } */
            /* Color color = new Color();
            color.Nombre = "Amarillo";
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
            /* Operacion operacion = new Operacion();
            operacion.Codigo = "AA12H";
            operacion.Nombre = "Prueba";
            operacion.Descripcion = "Se tine que hacer la prueba";
            operacion.Horas = 2;
            operacion.Estado = true;
            rop.Add(operacion);

            Console.WriteLine("Se agrego Correctamente"); */

            /* GrupoRepuesto grupoRepuesto = new GrupoRepuesto();
            grupoRepuesto.Grupo = "Electrico";
            grupoRepuesto.Estado = true;
            rgr.Add(grupoRepuesto);
            Console.WriteLine("Se agrego Correctamente"); */

           /*  TipoVehiculo tipoVehiculo = new TipoVehiculo();
            tipoVehiculo.Tipo = "Autom??vil ";
            tipoVehiculo.Descricion = "Vehiculo";
            tipoVehiculo.Estado = true;
            rtv.Add(tipoVehiculo);
            Console.WriteLine("Se agrego Correctamente"); */


            /* GrupoRepuesto gRepuesto = new GrupoRepuesto();
            gRepuesto.Grupo = "Electrico";
            gRepuesto.Estado = true;
            gRepuesto.Repuestos = new List<Repuesto>{
                new Repuesto{Referencia= "AAHH",Producto = "Bueno", Tipo ="Generico", Costo= 1000, Precio=2000,Cantidad=1,Estado=true},
                new Repuesto{Referencia= "AAJJ",Producto = "Bueno2", Tipo ="Original", Costo= 1000, Precio=2000,Cantidad=1,Estado=false}
            };
            rgr.Add(gRepuesto);
            Console.WriteLine("Se agrego Correctamente");   */

           /*  var repuestos = rgr.GetAll();
            foreach (var ree in repuestos)
            {
                Console.WriteLine(ree.Grupo);
                Console.WriteLine(ree.Estado);
                foreach (var item in repuesto)
                {
                    Console.WriteLine(item.Producto);
                }
                
                Console.WriteLine("--------------------\n");
            }  */
        
        }
    }
}