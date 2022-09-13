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
    public class EditColorModel : PageModel
    {
        private readonly IRepositorioColor repositorioColor;
        [BindProperty] //Se encarga de hacer un enlace del modelo y la pagina razor

        public Color ListColor {get;set;}

        public EditColorModel(IRepositorioColor repositorioColor)
        {
            this.repositorioColor = repositorioColor;
        }
        public IActionResult OnGet(int? Idcolor)
        {
            if (Idcolor.HasValue)
            {
                ListColor = repositorioColor.Get(Idcolor.Value);
            }else
            {
                ListColor = new Color();
            }
            
            if (ListColor == null)
            {
                return RedirectToPage("./Hola");
            }
            else
                return Page();
        }
        public IActionResult OnPost()
        {
           /*  if (!ModelState.IsValid)
            {
                
            } */
            if (ListColor.Id>0)
            {
                ListColor = repositorioColor.Update(ListColor);
            }
            else
            {
                repositorioColor.Add(ListColor);
            }
            
            return RedirectToPage("Color");
        }
    }
}
