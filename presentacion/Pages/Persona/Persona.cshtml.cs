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
    public class PersonaModel : PageModel
    {
        private readonly IRepositorioPersona repositorioPersona;

        public IEnumerable<Persona> persona {get;set;}

        public PersonaModel(IRepositorioPersona repositorioPersona)
        {
            this.repositorioPersona = repositorioPersona;
        }

        public void OnGet()
        {
            persona = repositorioPersona.GetAll();
        }
    }
}
