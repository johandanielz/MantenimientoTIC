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
        public IEnumerable<Color> color {get;set;}
        public IEnumerable<Estilo> estilo {get;set;}
        public IEnumerable<Persona> persona {get;set;}
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
        
        public IActionResult OnGet(int? Idvehiculo)
        {
            persona = repositorioPersona.GetAll();
            color = repositorioColor.GetEstadoTrue();
            estilo = repositorioEstilo.GetEstadoTrue();
            marca = repositorioMarca.GetEstadoTrue();
            tipoVehiculo = repositorioTipoVehiculo.GetEstadoTrue();

            if (Idvehiculo.HasValue)
            {
                vehiculo = repositorioVehiculo.Get(Idvehiculo.Value);
            }else
            {
                vehiculo = new Vehiculo();
            }
            
            if (vehiculo == null)
            {
                return RedirectToPage("./Hola");
            }
            else
                return Page();
        }
        public IActionResult OnPost()
        {
            if (vehiculo.VehiculoId>0)
            {
                vehiculo = repositorioVehiculo.Update(vehiculo);
            }
            else
            {
                repositorioVehiculo.Add(vehiculo);
            }
            
            
            return RedirectToPage("Vehiculo");
        }
    }
}
