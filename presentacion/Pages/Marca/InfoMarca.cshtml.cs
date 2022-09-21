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
    public class InfoMarcaModel : PageModel
    {
        private readonly IRepositorioMarca repositorioMarca;
        [BindProperty] //Se encarga de hacer un enlace del modelo y la pagina razor

        public Marca InfoMarca {get;set;}

        public InfoMarcaModel(IRepositorioMarca repositorioMarca)
        {
            this.repositorioMarca = repositorioMarca;
        }
        public IActionResult OnGet(int Idmarca)
        {
            InfoMarca = repositorioMarca.Get(Idmarca);
            
            if (InfoMarca == null)
            {
                return RedirectToPage("./Hola");
            }
            else
                return Page();
        }
    }
}
