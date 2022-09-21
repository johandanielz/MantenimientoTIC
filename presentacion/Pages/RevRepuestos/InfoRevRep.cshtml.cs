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
    public class InfoRevRepModel : PageModel
    {
        private readonly IRepositorioRevRepuestos repositorioRevRepuestos;
        [BindProperty] //Se encarga de hacer un enlace del modelo y la pagina razor

        public RevRepuestos InfoRevRep {get;set;}

        public InfoRevRepModel(IRepositorioRevRepuestos repositorioRevRepuestos)
        {
            this.repositorioRevRepuestos = repositorioRevRepuestos;
        }
        public IActionResult OnGet(int IdrevRep)
        {
            InfoRevRep = repositorioRevRepuestos.Get(IdrevRep);
            
            if (InfoRevRep == null)
            {
                return RedirectToPage("./Hola");
            }
            else
                return Page();
        }
    }
}
