using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dominio;

namespace persistencia
{
    public interface IRepositorioTipoVehiculo
    {
        TipoVehiculo Add(TipoVehiculo tipoVehiculo);
        TipoVehiculo Update(TipoVehiculo tipoVehiculo);
        void Delete(int IdtipoVehiculo);
        TipoVehiculo Get(int IdtipoVehiculo);
        IEnumerable<TipoVehiculo> GetAll();
        IEnumerable<TipoVehiculo> GetEstadoTrue();
    }
}