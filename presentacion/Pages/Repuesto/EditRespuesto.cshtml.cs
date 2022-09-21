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
    public class EditRespuestoModel : PageModel
    {
        private readonly IRepositorioRepuesto repositorioRepuesto;
        private readonly IRepositorioGrupoRepuesto repositorioGrupoRepuesto;
        [BindProperty] //Se encarga de hacer un enlace del modelo y la pagina razor

        public Repuesto EditRepuesto {get;set;}
        public IEnumerable<GrupoRepuesto> GRrepuesto {get;set;}

        public EditRespuestoModel(IRepositorioRepuesto repositorioRepuesto,IRepositorioGrupoRepuesto repositorioGrupoRepuesto)
        {
            this.repositorioRepuesto = repositorioRepuesto;
            this.repositorioGrupoRepuesto = repositorioGrupoRepuesto;
        }

        public IActionResult OnGet(int? Idrepuesto)
        {
                GRrepuesto = repositorioGrupoRepuesto.GetEstadoTrue();

            if (Idrepuesto.HasValue)
            {   
                EditRepuesto = repositorioRepuesto.Get(Idrepuesto.Value);
            }else
            {
                EditRepuesto = new Repuesto();
            }
            
            if (EditRepuesto == null)
            {
                return RedirectToPage("./Hola");
            }
            else
                return Page();
        }
        public IActionResult OnPost()
        {
            if (EditRepuesto.RepuestoId>0)
            {
                EditRepuesto = repositorioRepuesto.Update(EditRepuesto);
            }
            else
            {
                repositorioRepuesto.Add(EditRepuesto);
            }
            
            return RedirectToPage("Respuesto");
        }
    }
}
