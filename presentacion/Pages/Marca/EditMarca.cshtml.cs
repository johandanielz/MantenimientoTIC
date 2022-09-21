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
    public class EditMarcaModel : PageModel
    {
        private readonly IRepositorioMarca repositorioMarca;
        [BindProperty] //Se encarga de hacer un enlace del modelo y la pagina razor

        public Marca ListMarca {get;set;}

        public EditMarcaModel(IRepositorioMarca repositorioMarca)
        {
            this.repositorioMarca = repositorioMarca;
        }
        public IActionResult OnGet(int? Idmarca)
        {
            if (Idmarca.HasValue)
            {
                ListMarca = repositorioMarca.Get(Idmarca.Value);
            }else
            {
                ListMarca = new Marca();
            }
            
            if (ListMarca == null)
            {
                return RedirectToPage("./Hola");
            }
            else
                return Page();
        }
        public IActionResult OnPost()
        {
            if (ListMarca.MarcaId>0)
            {
                ListMarca = repositorioMarca.Update(ListMarca);
            }
            else
            {
                repositorioMarca.Add(ListMarca);
            }
            
            return RedirectToPage("Marca");
        }
    }
}
