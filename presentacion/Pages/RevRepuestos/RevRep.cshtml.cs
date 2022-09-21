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
    public class RevRepModel : PageModel
    {
        private readonly IRepositorioRevRepuestos repositorioRevRepuestos;
        public IEnumerable<RevRepuestos> revRepuestos {get;set;}

        public RevRepModel(IRepositorioRevRepuestos repositorioRevRepuestos)
        {
            this.repositorioRevRepuestos = repositorioRevRepuestos;
        }

        public void OnGet()
        {
            revRepuestos = repositorioRevRepuestos.GetAll();
        }
    }
}
