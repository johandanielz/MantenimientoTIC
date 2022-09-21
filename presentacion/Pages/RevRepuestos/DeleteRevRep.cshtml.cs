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
    public class DeleteRevRepModel : PageModel
    {
        private readonly IRepositorioRevRepuestos repositorioRevRepuestos;
        public RevRepuestos DelRevRep {get;set;}

        public DeleteRevRepModel(IRepositorioRevRepuestos repositorioRevRepuestos)
        {
            this.repositorioRevRepuestos = repositorioRevRepuestos;
        }

        public void OnGet(int IdrevRep)
        { 
            DelRevRep = repositorioRevRepuestos.Get(IdrevRep);
        }

        public IActionResult OnPost(int IdrevRep)
        { 
            repositorioRevRepuestos.Delete(IdrevRep);

            return RedirectToPage("RevRep");
        }
    }
}
