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
    public class EditRevisionModel : PageModel
    {
        private readonly IRepositorioRevision repositorioRevision;
        private readonly IRepositorioVehiculo repositorioVehiculo;
        private readonly IRepositorioTecnico repositorioTecnico;
        [BindProperty] //Se encarga de hacer un enlace del modelo y la pagina razor

        public Revision EditRevision {get;set;}
        public IEnumerable<Vehiculo> vehiculo {get;set;}
        public IEnumerable<Tecnico> tecnico {get;set;}

        public EditRevisionModel(IRepositorioRevision repositorioRevision,IRepositorioVehiculo repositorioVehiculo,IRepositorioTecnico repositorioTecnico)
        {
            this.repositorioRevision = repositorioRevision;
            this.repositorioVehiculo = repositorioVehiculo;
            this.repositorioTecnico = repositorioTecnico;
        }

        public IActionResult OnGet(int? Idrevision)
        {
                vehiculo = repositorioVehiculo.GetAll();
                tecnico = repositorioTecnico.GetEstadoTrue();

            if (Idrevision.HasValue)
            {   
                EditRevision = repositorioRevision.Get(Idrevision.Value);
            }else
            {
                EditRevision = new Revision();
            }
            
            if (EditRevision == null)
            {
                return RedirectToPage("./Hola");
            }
            else
                return Page();
        }
        public IActionResult OnPost()
        {
            if (EditRevision.RevisionId>0)
            {
                EditRevision = repositorioRevision.Update(EditRevision);
            }
            else
            {
                repositorioRevision.Add(EditRevision);
            }
            
            return RedirectToPage("Revision");
        }
    }
}
