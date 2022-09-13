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
    public class DeleteTipoVModel : PageModel
    {
        private readonly IRepositorioTipoVehiculo repositorioTipoVehiculo;

        public TipoVehiculo DelTipoV {get;set;}

        public DeleteTipoVModel(IRepositorioTipoVehiculo repositorioTipoVehiculo)
        {
            this.repositorioTipoVehiculo = repositorioTipoVehiculo;
        }

        public void OnGet(int IdtipoV)
        { 
            DelTipoV = repositorioTipoVehiculo.Get(IdtipoV);
        }

        public IActionResult OnPost(int IdtipoV)
        { 
            repositorioTipoVehiculo.Delete(IdtipoV);

            return RedirectToPage("TipoVehiculo");
        }
    }
}
