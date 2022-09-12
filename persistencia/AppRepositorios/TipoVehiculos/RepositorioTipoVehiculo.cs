using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dominio;

namespace persistencia
{
    public class RepositorioTipoVehiculo : IRepositorioTipoVehiculo
    {
        private readonly AplicationsContext _appContext;

        public RepositorioTipoVehiculo(AplicationsContext appContext)
        {
            _appContext = appContext;
        }
        //Agregar
        TipoVehiculo IRepositorioTipoVehiculo.Add(TipoVehiculo tipoVehiculo){
            var new_tipoVehiculo = _appContext.tipoVehiculo.Add(tipoVehiculo);
            _appContext.SaveChanges();
            return new_tipoVehiculo.Entity; //devuelve la entiendad completa qeu ser guardo
        }
        //Eliminar
        void IRepositorioTipoVehiculo.Delete(int IdtipoVehiculo){
            var tipoVehiculoExiste = _appContext.tipoVehiculo.FirstOrDefault(
                tv => tv.Id == IdtipoVehiculo
            );

            if (tipoVehiculoExiste == null)
            return;
            _appContext.Remove(tipoVehiculoExiste);
            _appContext.SaveChanges();
            
        }
        //Obtener todos los registros
        IEnumerable<TipoVehiculo> IRepositorioTipoVehiculo.GetAll(){
            return _appContext.tipoVehiculo;
        }
        //Obtener un solo registro
        TipoVehiculo IRepositorioTipoVehiculo.Get(int IdtipoVehiculo){
            return _appContext.tipoVehiculo.FirstOrDefault(
                tv => tv.Id == IdtipoVehiculo
            );
        }
        //Actualizar
        TipoVehiculo IRepositorioTipoVehiculo.Update(TipoVehiculo tipoVehiculo){
            var tipoVehiculoEncontrado = _appContext.tipoVehiculo.FirstOrDefault(
                tv => tv.Id == tipoVehiculo.Id
            );
            if (tipoVehiculoEncontrado != null)
            {
                tipoVehiculoEncontrado.Estado = tipoVehiculo.Estado;
                tipoVehiculoEncontrado.Tipo = tipoVehiculo.Tipo;
                tipoVehiculoEncontrado.Descripcion = tipoVehiculo.Descripcion;
            }
            _appContext.SaveChanges();
            return tipoVehiculoEncontrado;
        }
    }
}