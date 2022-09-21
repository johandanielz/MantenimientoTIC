
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
    public class RevOpeModel : PageModel
    {
        private readonly IRepositorioRevOperaciones repositorioRevOperaciones;
        private readonly IRepositorioVehiculo repositorioVehiculo;
        public IEnumerable<RevOperaciones> revOperaciones {get;set;}
        public IEnumerable<Vehiculo> vehiculo {get;set;}

        public RevOpeModel(IRepositorioRevOperaciones repositorioRevOperaciones,IRepositorioVehiculo repositorioVehiculo)
        {
            this.repositorioRevOperaciones = repositorioRevOperaciones;
            this.repositorioVehiculo = repositorioVehiculo;
        }

        public void OnGet()
        {
            revOperaciones = repositorioRevOperaciones.GetAll();
        }
    }
}
