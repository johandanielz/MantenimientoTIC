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
    public class DeleteOperacionModel : PageModel
    {
        private readonly IRepositorioOperacion repositorioOperacion;

        public Operacion DelOperacion {get;set;}

        public DeleteOperacionModel(IRepositorioOperacion repositorioOperacion)
        {
            this.repositorioOperacion = repositorioOperacion;
        }

        public void OnGet(int Idoperacion)
        { 
            DelOperacion = repositorioOperacion.Get(Idoperacion);
        }

        public IActionResult OnPost(int Idoperacion)
        { 
            repositorioOperacion.Delete(Idoperacion);

            return RedirectToPage("Operacion");
        }
    }
}
