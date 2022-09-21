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
    public class InfoRepuestoModel : PageModel
    {
        private readonly IRepositorioRepuesto repositorioRepuesto;
        [BindProperty] //Se encarga de hacer un enlace del modelo y la pagina razor

        public Repuesto InfoRepuesto {get;set;}

        public InfoRepuestoModel(IRepositorioRepuesto repositorioRepuesto)
        {
            this.repositorioRepuesto = repositorioRepuesto;
        }
        public IActionResult OnGet(int Idrepuesto)
        {
            InfoRepuesto = repositorioRepuesto.Get(Idrepuesto);
            
            if (InfoRepuesto == null)
            {
                return RedirectToPage("./Hola");
            }
            else
                return Page();
        }
    }
}
