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
    public class MarcaModel : PageModel
    {
        private readonly IRepositorioMarca repositorioMarca;
        public IEnumerable<Marca> marca {get;set;}

        public MarcaModel(IRepositorioMarca repositorioMarca)
        {
            this.repositorioMarca = repositorioMarca;
        }

        public void OnGet()
        {
            marca = repositorioMarca.GetAll();
        }
    }
}
