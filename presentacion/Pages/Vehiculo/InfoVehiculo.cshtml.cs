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
    public class InfoVehiculoModel : PageModel
    {
        private readonly IRepositorioVehiculo repositorioVehiculo;
        [BindProperty] //Se encarga de hacer un enlace del modelo y la pagina razor

        public Vehiculo InfoVehiculo {get;set;}

        public InfoVehiculoModel(IRepositorioVehiculo repositorioVehiculo)
        {
            this.repositorioVehiculo = repositorioVehiculo;
        }
        public IActionResult OnGet(int Idvehiculo)
        {
            InfoVehiculo = repositorioVehiculo.Get(Idvehiculo);
            
            if (InfoVehiculo == null)
            {
                return RedirectToPage("./Hola");
            }
            else
                return Page();
        }
    }
}
