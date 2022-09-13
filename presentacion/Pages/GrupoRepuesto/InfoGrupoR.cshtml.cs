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
    public class InfoGrupoRModel : PageModel
    {
        private readonly IRepositorioGrupoRepuesto repositorioGrupoRepuesto;
        [BindProperty] //Se encarga de hacer un enlace del modelo y la pagina razor

        public GrupoRepuesto InfoGrupoR {get;set;}

        public InfoGrupoRModel(IRepositorioGrupoRepuesto repositorioGrupoRepuesto)
        {
            this.repositorioGrupoRepuesto = repositorioGrupoRepuesto;
        }
        public IActionResult OnGet(int IdgrupoR)
        {
            InfoGrupoR = repositorioGrupoRepuesto.Get(IdgrupoR);
            
            if (InfoGrupoR == null)
            {
                return RedirectToPage("./Hola");
            }
            else
                return Page();
        }
    }
}
