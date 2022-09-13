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
    public class InfoTipoVModel : PageModel
    {
         private readonly IRepositorioTipoVehiculo repositorioTipoVehiculo;
        [BindProperty] //Se encarga de hacer un enlace del modelo y la pagina razor

        public TipoVehiculo InfoTipoV {get;set;}

        public InfoTipoVModel(IRepositorioTipoVehiculo repositorioTipoVehiculo)
        {
            this.repositorioTipoVehiculo = repositorioTipoVehiculo;
        }
        public IActionResult OnGet(int IdtipoV)
        {
            InfoTipoV = repositorioTipoVehiculo.Get(IdtipoV);
            
            if (InfoTipoV == null)
            {
                return RedirectToPage("./Hola");
            }
            else
                return Page();
        }
    }
}
