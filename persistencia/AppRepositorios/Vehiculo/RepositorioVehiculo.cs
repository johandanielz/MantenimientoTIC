using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dominio;
using Microsoft.EntityFrameworkCore;

namespace persistencia
{
    public class RepositorioVehiculo : IRepositorioVehiculo
    {
        private readonly AplicationsContext _appContext;

        public RepositorioVehiculo(AplicationsContext appContext)
        {
            _appContext = appContext;
        }
        //Agregar
        Vehiculo IRepositorioVehiculo.Add(Vehiculo vehiculo){
            var new_vehiculo = _appContext.vehiculo.Add(vehiculo);
            _appContext.SaveChanges();
            return new_vehiculo.Entity; //devuelve la entiendad completa qeu ser guardo
        }
        //Eliminar
        void IRepositorioVehiculo.Delete(int Idvehiculo){
            var vehiculoExiste = _appContext.vehiculo.Include(v => v.color).Include(v => v.estilo).Include(v => v.marca).Include(v => v.tipoVehiculo).Include(v => v.persona).FirstOrDefault(
                v => v.VehiculoId == Idvehiculo
            );

            if (vehiculoExiste == null)
            return;
            _appContext.Remove(vehiculoExiste);
            _appContext.SaveChanges();
            
        }
        //Obtener todos los registros
        IEnumerable<Vehiculo> IRepositorioVehiculo.GetAll(){
            return _appContext.vehiculo.Include(c => c.color).Include(c => c.estilo).Include(c => c.marca).Include(v => v.tipoVehiculo).Include(v => v.persona);
        }
        IEnumerable<Color> IRepositorioVehiculo.GetColorTrue(){
            return _appContext.color.Where(c => c.Estado == true).ToList();
        }
        //Obtener un solo registro
        Vehiculo IRepositorioVehiculo.Get(int Idvehiculo){
            return _appContext.vehiculo.Include(v => v.color).Include(v => v.estilo).Include(v => v.marca).Include(v => v.tipoVehiculo).Include(v => v.persona).FirstOrDefault(
                v => v.VehiculoId == Idvehiculo
            );
        }
        //Actualizar
        Vehiculo IRepositorioVehiculo.Update(Vehiculo vehiculo){
            var vehiculoEncontrado = _appContext.vehiculo.FirstOrDefault(
                v => v.VehiculoId == vehiculo.VehiculoId
            );
            if (vehiculoEncontrado != null)
            {
                vehiculoEncontrado.Placa = vehiculo.Placa;
                vehiculoEncontrado.Modelo = vehiculo.Modelo;
                vehiculoEncontrado.Servicio = vehiculo.Servicio;
                vehiculoEncontrado.TipoVehiculoId = vehiculo.TipoVehiculoId;
                vehiculoEncontrado.EstiloId = vehiculo.EstiloId;
                vehiculoEncontrado.ColorId = vehiculo.ColorId;
                vehiculoEncontrado.PersonaId = vehiculo.PersonaId;
            }
            _appContext.SaveChanges();
            return vehiculoEncontrado;
        }
    }
}