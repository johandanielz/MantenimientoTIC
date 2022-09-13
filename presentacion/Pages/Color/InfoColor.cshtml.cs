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
    public class InfoColorModel : PageModel
    {
        private readonly IRepositorioColor repositorioColor;
        [BindProperty] //Se encarga de hacer un enlace del modelo y la pagina razor

        public Color InfoColor {get;set;}

        public InfoColorModel(IRepositorioColor repositorioColor)
        {
            this.repositorioColor = repositorioColor;
        }
        public IActionResult OnGet(int Idcolor)
        {
            InfoColor = repositorioColor.Get(Idcolor);
            
            if (InfoColor == null)
            {
                return RedirectToPage("./Hola");
            }
            else
                return Page();
        }
    }
}
