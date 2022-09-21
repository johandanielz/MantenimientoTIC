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
    public class InfoEstiloModel : PageModel
    {
        private readonly IRepositorioEstilo repositorioEstilo;
        [BindProperty] //Se encarga de hacer un enlace del modelo y la pagina razor

        public Estilo InfoEstilo {get;set;}

        public InfoEstiloModel(IRepositorioEstilo repositorioEstilo)
        {
            this.repositorioEstilo = repositorioEstilo;
        }
        public IActionResult OnGet(int Idestilo)
        {
            InfoEstilo = repositorioEstilo.Get(Idestilo);
            
            if (InfoEstilo == null)
            {
                return RedirectToPage("./Hola");
            }
            else
                return Page();
        }
    }
}
