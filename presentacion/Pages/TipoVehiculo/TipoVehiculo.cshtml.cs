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
    public class TipoVehiculoModel : PageModel
    {
        private readonly IRepositorioTipoVehiculo repositorioTipoVehiculo;
        public IEnumerable<TipoVehiculo> tipoVehiculo {get;set;}

        public TipoVehiculoModel(IRepositorioTipoVehiculo repositorioTipoVehiculo)
        {
            this.repositorioTipoVehiculo = repositorioTipoVehiculo;
        }
        public void OnGet()
        {
            tipoVehiculo = repositorioTipoVehiculo.GetAll(); 
        }
    }
}
