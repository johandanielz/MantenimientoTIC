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
    public class InfoRevisionModel : PageModel
    {
        private readonly IRepositorioRevision repositorioRevision;
        [BindProperty] //Se encarga de hacer un enlace del modelo y la pagina razor

        public Revision InfoRevision {get;set;}

        public InfoRevisionModel(IRepositorioRevision repositorioRevision)
        {
            this.repositorioRevision = repositorioRevision;
        }
        public IActionResult OnGet(int Idrevision)
        {
            InfoRevision = repositorioRevision.Get(Idrevision);
            
            if (InfoRevision == null)
            {
                return RedirectToPage("./Hola");
            }
            else
                return Page();
        }
    }
}
