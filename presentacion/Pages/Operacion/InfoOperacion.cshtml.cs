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
    public class InfoOperacionModel : PageModel
    {
        private readonly IRepositorioOperacion repositorioOperacion;
        [BindProperty] //Se encarga de hacer un enlace del modelo y la pagina razor

        public Operacion InfoOperacion {get;set;}

        public InfoOperacionModel(IRepositorioOperacion repositorioOperacion)
        {
            this.repositorioOperacion = repositorioOperacion;
        }
        public IActionResult OnGet(int Idoperacion)
        {
            InfoOperacion = repositorioOperacion.Get(Idoperacion);
            
            if (InfoOperacion == null)
            {
                return RedirectToPage("./Hola");
            }
            else
                return Page();
        }
    }
}
