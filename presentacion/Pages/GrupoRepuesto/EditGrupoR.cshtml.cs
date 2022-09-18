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
    public class EditGrupoRModel : PageModel
    {
        private readonly IRepositorioGrupoRepuesto repositorioGrupoRepuesto;
        [BindProperty] //Se encarga de hacer un enlace del modelo y la pagina razor

        public GrupoRepuesto ListGrupoR {get;set;}

        public EditGrupoRModel(IRepositorioGrupoRepuesto repositorioGrupoRepuesto)
        {
            this.repositorioGrupoRepuesto = repositorioGrupoRepuesto;
        }
        public IActionResult OnGet(int? IdgrupoR)
        {
            if (IdgrupoR.HasValue)
            {
                ListGrupoR = repositorioGrupoRepuesto.Get(IdgrupoR.Value);
            }else
            {
                ListGrupoR = new GrupoRepuesto();
            }
            
            if (ListGrupoR == null)
            {
                return RedirectToPage("./Hola");
            }
            else
                return Page();
        }
        public IActionResult OnPost()
        {
           /*  if (!ModelState.IsValid)
            {
                
            } */
            Console.WriteLine(ListGrupoR.Estado);
            if (ListGrupoR.GrupoRepuestoId>0)
            {
                ListGrupoR = repositorioGrupoRepuesto.Update(ListGrupoR);
            }
            else
            {
                repositorioGrupoRepuesto.Add(ListGrupoR);
            }
            
            return RedirectToPage("GrupoRepuesto");
        }
    }
}
