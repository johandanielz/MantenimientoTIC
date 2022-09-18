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
    public class DeleteVehiculoModel : PageModel
    {
        private readonly IRepositorioVehiculo repositorioVehiculo;
        public Vehiculo DelVehiculo {get;set;}

        public DeleteVehiculoModel(IRepositorioVehiculo repositorioVehiculo)
        {
            this.repositorioVehiculo = repositorioVehiculo;
        }

        public void OnGet(int Idvehiculo)
        { 
            DelVehiculo = repositorioVehiculo.Get(Idvehiculo);
        }

        public IActionResult OnPost(int Idvehiculo)
        { 
            repositorioVehiculo.Delete(Idvehiculo);

            return RedirectToPage("Vehiculo");
        }
    }
}
