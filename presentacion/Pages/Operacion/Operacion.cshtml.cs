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
    public class OperacionModel : PageModel
    {
        private readonly IRepositorioOperacion repositorioOperacion;
        public IEnumerable<Operacion> operacion {get; set;}

        public OperacionModel(IRepositorioOperacion repositorioOperacion)
        {
            this.repositorioOperacion = repositorioOperacion;
        }
        public void OnGet()
        {
            operacion = repositorioOperacion.GetAll();
        }
    }
}
