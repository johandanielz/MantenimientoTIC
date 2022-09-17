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
    public class ConsltPersonasModel : PageModel
    {
        private readonly IRepositorioPersona repositorioPersona;
        [BindProperty] //Se encarga de hacer un enlace del modelo y la pagina razor

        public Persona ListPersona {get;set;}

        public ConsltPersonasModel(IRepositorioPersona repositorioPersona)
        {
            this.repositorioPersona = repositorioPersona;
        }
        /* public void OnGet()
        {
            ListPersona = new Persona();
        } */
        public IActionResult OnPost()
        {
            if (ListPersona != null)
            {
                ListPersona = repositorioPersona.GetCedula(ListPersona.Cedula);
            }
            return Page();
        }
    }
}
