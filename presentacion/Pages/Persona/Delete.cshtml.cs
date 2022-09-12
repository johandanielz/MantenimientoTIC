using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using dominio;
using persistencia;

namespace MyApp.Namespace
{
    public class DeleteModel : PageModel
    {
        private readonly IRepositorioPersona repositorioPersona;
        public Persona DelPersona {get;set;}

        public DeleteModel(IRepositorioPersona repositorioPersona)
        {
            this.repositorioPersona = repositorioPersona;
        }

        public void OnGet(int Idpersona)
        { 
            DelPersona = repositorioPersona.Get(Idpersona);
        }

        public IActionResult OnPost(int Idpersona)
        { 
            repositorioPersona.Delete(Idpersona);

            return RedirectToPage("Persona");
        }
    }
}
