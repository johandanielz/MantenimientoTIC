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
    public class DeleteGrupoRModel : PageModel
    {
        private readonly IRepositorioGrupoRepuesto repositorioGrupoRepuesto;
        public GrupoRepuesto DelGrupoR {get;set;}

        public DeleteGrupoRModel(IRepositorioGrupoRepuesto repositorioGrupoRepuesto)
        {
            this.repositorioGrupoRepuesto = repositorioGrupoRepuesto;
        }

        public void OnGet(int IdgrupoR)
        { 
            DelGrupoR = repositorioGrupoRepuesto.Get(IdgrupoR);
        }

        public IActionResult OnPost(int IdgrupoR)
        { 
            repositorioGrupoRepuesto.Delete(IdgrupoR);

            return RedirectToPage("GrupoRepuesto");
        }
    }
}
