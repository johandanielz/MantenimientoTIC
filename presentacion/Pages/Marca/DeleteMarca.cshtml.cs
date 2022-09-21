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
    public class DeleteMarcaModel : PageModel
    {
        private readonly IRepositorioMarca repositorioMarca;
        public Marca DelMarca {get;set;}

        public DeleteMarcaModel(IRepositorioMarca repositorioMarca)
        {
            this.repositorioMarca = repositorioMarca;
        }

        public void OnGet(int Idmarca)
        { 
            DelMarca = repositorioMarca.Get(Idmarca);
        }

        public IActionResult OnPost(int Idmarca)
        { 
            repositorioMarca.Delete(Idmarca);

            return RedirectToPage("Marca");
        }
    }
}
