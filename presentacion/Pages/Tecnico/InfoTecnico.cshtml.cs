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
    public class InfoTecnicoModel : PageModel
    {
        private readonly IRepositorioTecnico repositorioTecnico;
        [BindProperty] //Se encarga de hacer un enlace del modelo y la pagina razor

        public Tecnico InfoTecnico {get;set;}

        public InfoTecnicoModel(IRepositorioTecnico repositorioTecnico)
        {
            this.repositorioTecnico = repositorioTecnico;
        }
        public IActionResult OnGet(int Idtecnico)
        {
            InfoTecnico = repositorioTecnico.Get(Idtecnico);
            
            if (InfoTecnico == null)
            {
                return RedirectToPage("./Hola");
            }
            else
                return Page();
        }
    }
}
