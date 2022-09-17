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
    public class RespuestoModel : PageModel
    {
       private readonly IRepositorioRepuesto repositorioRepuesto;

        public IEnumerable<Repuesto> repuesto {get;set;}

        public IEnumerable<GrupoRepuesto> GRrepuesto {get;set;}

        public RespuestoModel(IRepositorioRepuesto repositorioRepuesto)
        {
            this.repositorioRepuesto = repositorioRepuesto;
        }

        public void OnGet()
        {
            repuesto = repositorioRepuesto.GetAll();
            GRrepuesto = repositorioRepuesto.GetGrupoRespuestoTrue();
        }
    }
}
