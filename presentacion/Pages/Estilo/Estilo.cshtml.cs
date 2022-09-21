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
    public class EstiloModel : PageModel
    {
        private readonly IRepositorioEstilo repositorioEstilo;
        public IEnumerable<Estilo> estilo {get;set;}

        public EstiloModel(IRepositorioEstilo repositorioEstilo)
        {
            this.repositorioEstilo = repositorioEstilo;
        }

        public void OnGet()
        {
            estilo = repositorioEstilo.GetAll();
        }
    }
}
