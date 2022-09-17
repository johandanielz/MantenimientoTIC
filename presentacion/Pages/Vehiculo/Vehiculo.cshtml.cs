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
    public class VehiculoModel : PageModel
    {
        private readonly IRepositorioVehiculo repositorioVehiculo;
        private readonly IRepositorioPersona repositorioPersona;
        private readonly IRepositorioColor repositorioColor;
    
        public IEnumerable<Vehiculo> vehiculo {get;set;}
        public IEnumerable<Persona> persona {get;set;}
        public IEnumerable<Color> color {get;set;}

        public VehiculoModel(IRepositorioVehiculo repositorioVehiculo,IRepositorioPersona repositorioPersona,IRepositorioColor repositorioColor )
        {
            this.repositorioVehiculo = repositorioVehiculo;
            this.repositorioPersona = repositorioPersona;
            this.repositorioColor = repositorioColor;
        }

        public void OnGet()
        {
            vehiculo = repositorioVehiculo.GetAll();
            persona = repositorioPersona.GetAll();
            color = repositorioColor.GetAll();
        }
    }
}
