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
    public class DeleteColorModel : PageModel
    {
        private readonly IRepositorioColor repositorioColor;
        public Color DelColor {get;set;}

        public DeleteColorModel(IRepositorioColor repositorioColor)
        {
            this.repositorioColor = repositorioColor;
        }

        public void OnGet(int Idcolor)
        { 
            DelColor = repositorioColor.Get(Idcolor);
        }

        public IActionResult OnPost(int Idcolor)
        { 
            repositorioColor.Delete(Idcolor);

            return RedirectToPage("Color");
        }
    }
}
