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
    public class InfoRevOpeModel : PageModel
    {
        private readonly IRepositorioRevOperaciones repositorioRevOperaciones;
        [BindProperty] //Se encarga de hacer un enlace del modelo y la pagina razor

        public RevOperaciones InfoRevOpe {get;set;}

        public InfoRevOpeModel(IRepositorioRevOperaciones repositorioRevOperaciones)
        {
            this.repositorioRevOperaciones = repositorioRevOperaciones;
        }
        public IActionResult OnGet(int IdrevOpe)
        {
            InfoRevOpe = repositorioRevOperaciones.Get(IdrevOpe);
            
            if (InfoRevOpe == null)
            {
                return RedirectToPage("./Hola");
            }
            else
                return Page();
        }
    }
}
