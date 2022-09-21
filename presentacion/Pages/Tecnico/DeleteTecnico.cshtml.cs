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
    public class DeleteTecnicoModel : PageModel
    {
        private readonly IRepositorioTecnico repositorioTecnico;
        public Tecnico DelTecnico {get;set;}

        public DeleteTecnicoModel(IRepositorioTecnico repositorioTecnico)
        {
            this.repositorioTecnico = repositorioTecnico;
        }

        public void OnGet(int Idtecnico)
        { 
            DelTecnico = repositorioTecnico.Get(Idtecnico);
        }

        public IActionResult OnPost(int Idtecnico)
        { 
            repositorioTecnico.Delete(Idtecnico);

            return RedirectToPage("Tecnico");
        }
    }
}
