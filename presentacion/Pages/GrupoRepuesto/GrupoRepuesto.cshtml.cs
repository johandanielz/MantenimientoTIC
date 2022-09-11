using System.Collections;
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
    public class GrupoRepuestoModel : PageModel
    {
        private readonly IRepositorioGrupoRepuesto repositorioGrupoRepuesto;
        public IEnumerable<GrupoRepuesto> grupoRepuesto {get;set;}
        public GrupoRepuestoModel(IRepositorioGrupoRepuesto repositorioGrupoRepuesto)
        {
            this.repositorioGrupoRepuesto = repositorioGrupoRepuesto;
        }
        public void OnGet()
        {
           grupoRepuesto =  repositorioGrupoRepuesto.GetAll();
        }
    }
}
