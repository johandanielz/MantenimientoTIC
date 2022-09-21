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
    public class DeleteRevOpeModel : PageModel
    {
        private readonly IRepositorioRevOperaciones repositorioRevOperaciones;
        public RevOperaciones DelRevOpe {get;set;}

        public DeleteRevOpeModel(IRepositorioRevOperaciones repositorioRevOperaciones)
        {
            this.repositorioRevOperaciones = repositorioRevOperaciones;
        }

        public void OnGet(int IdrevOpe)
        { 
            DelRevOpe = repositorioRevOperaciones.Get(IdrevOpe);
        }

        public IActionResult OnPost(int IdrevOpe)
        { 
            repositorioRevOperaciones.Delete(IdrevOpe);

            return RedirectToPage("RevOpe");
        }
    }
}
