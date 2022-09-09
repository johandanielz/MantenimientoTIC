using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dominio;

namespace persistencia
{
    public class RepositorioOperacion : IRepositorioOperacion
    {
        private readonly AplicationsContext _appContext;

        public RepositorioOperacion(AplicationsContext appContext)
        {
            _appContext = appContext;
        }
        //Agregar
        Operacion IRepositorioOperacion.Add(Operacion operacion){
            var new_operacion = _appContext.operacion.Add(operacion);
            _appContext.SaveChanges();
            return new_operacion.Entity; //devuelve la entiendad completa qeu ser guardo
        }
        //Eliminar
        void IRepositorioOperacion.Delete(int Idoperacion){
            var operacionExiste = _appContext.operacion.FirstOrDefault(
                o => o.Id == Idoperacion
            );

            if (operacionExiste == null)
            return;
            _appContext.Remove(Idoperacion);
            _appContext.SaveChanges();
            
        }
        //Obtener todos los registros
        IEnumerable<Operacion> IRepositorioOperacion.GetAll(){
            return _appContext.operacion;
        }
        //Obtener un solo registro
        Operacion IRepositorioOperacion.Get(int Idoperacion){
            return _appContext.operacion.FirstOrDefault(
                o => o.Id == Idoperacion
            );
        }
        //Actualizar
        Operacion IRepositorioOperacion.Update(Operacion operacion){
            var operacionEncontrada = _appContext.operacion.FirstOrDefault(
                o => o.Id == operacion.Id
            );
            if (operacionEncontrada != null)
            {
                operacionEncontrada.Codigo = operacion.Codigo;
                operacionEncontrada.Nombre = operacion.Nombre;
                operacionEncontrada.Descripcion = operacion.Descripcion;
                operacionEncontrada.Horas = operacion.Horas;
                operacionEncontrada.Estado = operacion.Estado;
            }
            _appContext.SaveChanges();
            return operacionEncontrada;
        }
    }
}