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
    public class EditModel : PageModel
    {
        private readonly IRepositorioPersona repositorioPersona;
        [BindProperty] //Se encarga de hacer un enlace del modelo y la pagina razor

        public Persona ListPersona {get;set;}

        public EditModel(IRepositorioPersona repositorioPersona)
        {
            this.repositorioPersona = repositorioPersona;
        }

        public IActionResult OnGet(int? Idpersona)
        {
            if (Idpersona.HasValue)
            {
                ListPersona = repositorioPersona.Get(Idpersona.Value);
            }else
            {
                ListPersona = new Persona();
            }
            
            if (ListPersona == null)
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
            if (ListPersona.PersonaId>0)
            {
                ListPersona = repositorioPersona.Update(ListPersona);
            }
            else
            {
                repositorioPersona.Add(ListPersona);
            }
            
            return RedirectToPage("Persona");
        }
    }
}
