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
    public class DeleteRepuestoModel : PageModel
    {
        private readonly IRepositorioRepuesto repositorioRepuesto;
        public Repuesto DelRepuesto {get;set;}

        public DeleteRepuestoModel(IRepositorioRepuesto repositorioRepuesto)
        {
            this.repositorioRepuesto = repositorioRepuesto;
        }

        public void OnGet(int Idrepuesto)
        { 
            DelRepuesto = repositorioRepuesto.Get(Idrepuesto);
        }

        public IActionResult OnPost(int Idrepuesto)
        { 
            repositorioRepuesto.Delete(Idrepuesto);

            return RedirectToPage("Respuesto");
        }
    }
}
