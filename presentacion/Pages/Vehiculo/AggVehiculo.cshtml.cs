using System.Net.Cache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using dominio;
using persistencia;

namespace presentacion.Pages
{
    public class AggVehiculoModel : PageModel
    {
        private readonly IRepositorioVehiculo repositorioVehiculo;
        private readonly IRepositorioPersona repositorioPersona;
        private readonly IRepositorioColor repositorioColor;
        private readonly IRepositorioEstilo repositorioEstilo;
        private readonly IRepositorioMarca repositorioMarca;
        private readonly IRepositorioTipoVehiculo repositorioTipoVehiculo;
        [BindProperty]

        public Vehiculo vehiculo {get;set;}
        public Persona persona {get;set;}
        public Color color {get;set;}
        /* public IEnumerable<Color> color {get;set;} */
        public List<SelectListItem> nombreColor {get;set;} 
        public IEnumerable<Estilo> estilo {get;set;}
        public IEnumerable<Marca> marca {get;set;}
        public IEnumerable<TipoVehiculo> tipoVehiculo {get;set;}
    
        public AggVehiculoModel(IRepositorioVehiculo repositorioVehiculo, IRepositorioPersona repositorioPersona, IRepositorioColor repositorioColor, IRepositorioEstilo repositorioEstilo,IRepositorioMarca repositorioMarca,IRepositorioTipoVehiculo repositorioTipoVehiculo)
        {
            this.repositorioVehiculo = repositorioVehiculo;
            this.repositorioPersona = repositorioPersona;
            this.repositorioColor = repositorioColor;
            this.repositorioEstilo = repositorioEstilo;
            this.repositorioMarca = repositorioMarca;
            this.repositorioTipoVehiculo = repositorioTipoVehiculo;
        }
        public void OnGet()
        {
            persona = new Persona();
            /* color = repositorioVehiculo.GetColorTrue(); */
            nombreColor = repositorioColor.GetNombreColor();
            estilo = repositorioEstilo.GetAll();
            marca = repositorioMarca.GetAll();
            tipoVehiculo = repositorioTipoVehiculo.GetAll();
        }
        public IActionResult OnPost(int Idpersona)
        {
            persona = repositorioPersona.Get(Idpersona);
            if (persona!=null)
            {
                string dato = Request.Form["colorNames"];
                Console.WriteLine(dato);
                var res = dato.Split();

                color = repositorioColor.GetColorName(res[0]);
                vehiculo.color = color;
                if (persona.vehiculo==null)
                {
                    persona.vehiculo = new List<Vehiculo>();
                    persona.vehiculo.Add(vehiculo);
                }
                else
                {
                    repositorioVehiculo.Add(vehiculo);
                }
                repositorioPersona.Update(persona);
                return Page();
            }
            return RedirectToPage("Persona");
        }
    }
}
