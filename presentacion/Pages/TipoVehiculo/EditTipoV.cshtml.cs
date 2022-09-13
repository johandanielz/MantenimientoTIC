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
    public class EditTipoVModel : PageModel
    {
        private readonly IRepositorioTipoVehiculo repositorioTipoVehiculo;
        [BindProperty] //Se encarga de hacer un enlace del modelo y la pagina razor

        public TipoVehiculo EditTipoV {get;set;}

        public EditTipoVModel(IRepositorioTipoVehiculo repositorioTipoVehiculo)
        {
            this.repositorioTipoVehiculo = repositorioTipoVehiculo;
        }
        public IActionResult OnGet(int? IdtipoV)
        {
            if (IdtipoV.HasValue)
            {
                EditTipoV = repositorioTipoVehiculo.Get(IdtipoV.Value);
            }else
            {
                EditTipoV = new TipoVehiculo();
            }
            
            if (EditTipoV == null)
            {
                return RedirectToPage("./Hola");
            }
            else
                return Page();
        }
        public IActionResult OnPost()
        {
           /*  if (!ModelState.IsValid)
            {
                
            } */
            if (EditTipoV.Id>0)
            {
                EditTipoV = repositorioTipoVehiculo.Update(EditTipoV);
            }
            else
            {
                repositorioTipoVehiculo.Add(EditTipoV);
            }
            
            return RedirectToPage("TipoVehiculo");
        }
    }
}
