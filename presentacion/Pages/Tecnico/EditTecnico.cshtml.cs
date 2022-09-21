using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using dominio;
using persistencia;

namespace presentacion.Pages
{
    public class EditTecnicoModel : PageModel
    {
        private readonly IRepositorioTecnico repositorioTecnico;
        private readonly IRepositorioPersona repositorioPersona;
        private readonly IRepositorioTipoVehiculo repositorioTipoVehiculo;

        [BindProperty]

        public Tecnico EditTecnico {get;set;}
        public IEnumerable<Persona> persona {get;set;}
        public IEnumerable<TipoVehiculo> tipoVehiculo {get;set;}
    
        public EditTecnicoModel(IRepositorioTecnico repositorioTecnico,IRepositorioPersona repositorioPersona,IRepositorioTipoVehiculo repositorioTipoVehiculo)
        {
            this.repositorioTecnico = repositorioTecnico;
            this.repositorioPersona = repositorioPersona;
            this.repositorioTipoVehiculo = repositorioTipoVehiculo;
        }
        
        public IActionResult OnGet(int? Idtecnico)
        {
            persona = repositorioPersona.GetPersonaTecnico();
            tipoVehiculo = repositorioTipoVehiculo.GetEstadoTrue();

            if (Idtecnico.HasValue)
            {
                EditTecnico = repositorioTecnico.Get(Idtecnico.Value);
            }else
            {
                EditTecnico = new Tecnico();
            }
            
            if (EditTecnico == null)
            {
                return RedirectToPage("./Hola");
            }
            else
                return Page();
        }
        public IActionResult OnPost()
        {
            if (EditTecnico.TecnicoId>0)
            {
                EditTecnico = repositorioTecnico.Update(EditTecnico);
            }
            else
            {
                repositorioTecnico.Add(EditTecnico);
            }
            
            return RedirectToPage("Tecnico");
        }
    }
}
