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
    public class EditOperacionModel : PageModel
    {
        private readonly IRepositorioOperacion repositorioOperacion;
        [BindProperty] //Se encarga de hacer un enlace del modelo y la pagina razor

        public Operacion EditOperacion {get;set;}

        public EditOperacionModel(IRepositorioOperacion repositorioOperacion)
        {
            this.repositorioOperacion = repositorioOperacion;
        }
        public IActionResult OnGet(int? Idoperacion)
        {
            if (Idoperacion.HasValue)
            {
                EditOperacion = repositorioOperacion.Get(Idoperacion.Value);
            }else
            {
                EditOperacion = new Operacion();
            }
            
            if (EditOperacion == null)
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
            if (EditOperacion.Id>0)
            {
                EditOperacion = repositorioOperacion.Update(EditOperacion);
            }
            else
            {
                repositorioOperacion.Add(EditOperacion);
            }
            
            return RedirectToPage("Operacion");
        }
    }
}
