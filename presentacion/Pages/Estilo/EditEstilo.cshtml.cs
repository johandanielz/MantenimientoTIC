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
    public class EditEstiloModel : PageModel
    {
        private readonly IRepositorioEstilo repositorioEstilo;
        [BindProperty] //Se encarga de hacer un enlace del modelo y la pagina razor

        public Estilo ListEstilo {get;set;}

        public EditEstiloModel(IRepositorioEstilo repositorioEstilo)
        {
            this.repositorioEstilo = repositorioEstilo;
        }
        public IActionResult OnGet(int? Idestilo)
        {
            if (Idestilo.HasValue)
            {
                ListEstilo = repositorioEstilo.Get(Idestilo.Value);
            }else
            {
                ListEstilo = new Estilo();
            }
            
            if (ListEstilo == null)
            {
                return RedirectToPage("./Hola");
            }
            else
                return Page();
        }
        public IActionResult OnPost()
        {
            if (ListEstilo.EstiloId>0)
            {
                ListEstilo = repositorioEstilo.Update(ListEstilo);
            }
            else
            {
                repositorioEstilo.Add(ListEstilo);
            }
            
            return RedirectToPage("Estilo");
        }
    }
}
