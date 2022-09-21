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
    public class EditRevRepModel : PageModel
    {
        private readonly IRepositorioRevRepuestos repositorioRevRepuestos;
        private readonly IRepositorioRevision repositorioRevision;
        private readonly IRepositorioRepuesto repositorioRepuesto;
        [BindProperty] //Se encarga de hacer un enlace del modelo y la pagina razor

        public RevRepuestos EditRevRep {get;set;}
        public IEnumerable<Revision> revision {get;set;}
        public IEnumerable<Repuesto> repuesto {get;set;}

        public EditRevRepModel(IRepositorioRevRepuestos repositorioRevRepuestos,IRepositorioRevision repositorioRevision,IRepositorioRepuesto repositorioRepuesto)
        {
            this.repositorioRevRepuestos = repositorioRevRepuestos;
            this.repositorioRevision = repositorioRevision;
            this.repositorioRepuesto = repositorioRepuesto;
        }

        public IActionResult OnGet(int? IdrevRep)
        {
                revision = repositorioRevision.GetAll();
                repuesto = repositorioRepuesto.GetEstadoTrue();

            if (IdrevRep.HasValue)
            {   
                EditRevRep = repositorioRevRepuestos.Get(IdrevRep.Value);
            }else
            {
                EditRevRep = new RevRepuestos();
            }
            
            if (EditRevRep == null)
            {
                return RedirectToPage("./Hola");
            }
            else
                return Page();
        }
        public IActionResult OnPost()
        {
            if (EditRevRep.RevRepuestosId>0)
            {
                EditRevRep = repositorioRevRepuestos.Update(EditRevRep);
            }
            else
            {
                repositorioRevRepuestos.Add(EditRevRep);
            }
            
            return RedirectToPage("RevRep");
        }
    }
}
