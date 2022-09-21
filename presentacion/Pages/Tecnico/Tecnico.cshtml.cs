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
    public class TecnicoModel : PageModel
    {
        private readonly IRepositorioTecnico repositorioTecnico;
        
        public IEnumerable<Tecnico> tecnico {get;set;}

        public TecnicoModel(IRepositorioTecnico repositorioTecnico)
        {
            this.repositorioTecnico = repositorioTecnico;
            
        }

        public void OnGet()
        {
            tecnico = repositorioTecnico.GetAll();
        }
    }
}
