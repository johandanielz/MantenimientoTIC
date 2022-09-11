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
    public class ColorModel : PageModel
    {
        private readonly IRepositorioColor repositorioColor;
        public IEnumerable<Color> color {get;set;}

        public ColorModel(IRepositorioColor repositorioColor)
        {
            this.repositorioColor = repositorioColor;
        }

        public void OnGet()
        {
            color = repositorioColor.GetAll();
        }
    }
}
