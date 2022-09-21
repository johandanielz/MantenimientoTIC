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
    public class DeleteRevisionModel : PageModel
    {
        private readonly IRepositorioRevision repositorioRevision;
        public Revision DelRevision {get;set;}

        public DeleteRevisionModel(IRepositorioRevision repositorioRevision)
        {
            this.repositorioRevision = repositorioRevision;
        }

        public void OnGet(int Idrevision)
        { 
            DelRevision = repositorioRevision.Get(Idrevision);
        }

        public IActionResult OnPost(int Idrevision)
        { 
            repositorioRevision.Delete(Idrevision);

            return RedirectToPage("Revision");
        }
    }
}
