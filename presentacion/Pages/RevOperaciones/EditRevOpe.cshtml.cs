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
    public class EditRevOpeModel : PageModel
    {
        private readonly IRepositorioRevOperaciones repositorioRevOperaciones;
        private readonly IRepositorioRevision repositorioRevision;
        private readonly IRepositorioOperacion repositorioOperacion;
        [BindProperty] //Se encarga de hacer un enlace del modelo y la pagina razor

        public RevOperaciones EditRevOper {get;set;}
        public IEnumerable<Revision> revision {get;set;}
        public IEnumerable<Operacion> operacion {get;set;}

        public EditRevOpeModel(IRepositorioRevOperaciones repositorioRevOperaciones,IRepositorioRevision repositorioRevision,IRepositorioOperacion repositorioOperacion)
        {
            this.repositorioRevOperaciones = repositorioRevOperaciones;
            this.repositorioRevision = repositorioRevision;
            this.repositorioOperacion = repositorioOperacion;
        }

        public IActionResult OnGet(int? IdrevOpe)
        {
                revision = repositorioRevision.GetAll();
                operacion = repositorioOperacion.GetAll();

            if (IdrevOpe.HasValue)
            {   
                EditRevOper = repositorioRevOperaciones.Get(IdrevOpe.Value);
            }else
            {
                EditRevOper = new RevOperaciones();
            }
            
            if (EditRevOper == null)
            {
                return RedirectToPage("./Hola");
            }
            else
                return Page();
        }
        public IActionResult OnPost()
        {
            if (EditRevOper.RevOperacionesId>0)
            {
                EditRevOper = repositorioRevOperaciones.Update(EditRevOper);
            }
            else
            {
                repositorioRevOperaciones.Add(EditRevOper);
            }
            
            return RedirectToPage("RevOpe");
        }
    }
}
