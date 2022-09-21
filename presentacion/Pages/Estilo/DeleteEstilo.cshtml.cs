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
    public class DeleteEstiloModel : PageModel
    {
        private readonly IRepositorioEstilo repositorioEstilo;
        public Estilo DelEstilo {get;set;}

        public DeleteEstiloModel(IRepositorioEstilo repositorioEstilo)
        {
            this.repositorioEstilo = repositorioEstilo;
        }

        public void OnGet(int Idestilo)
        { 
            DelEstilo = repositorioEstilo.Get(Idestilo);
        }

        public IActionResult OnPost(int Idestilo)
        { 
            repositorioEstilo.Delete(Idestilo);

            return RedirectToPage("Estilo");
        }
    }
}
