using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dominio;

namespace persistencia
{
    public class RepositorioEstilo : IRepositorioEstilo
    {
        private readonly AplicationsContext _appContext;

        public RepositorioEstilo(AplicationsContext appContext)
        {
            _appContext = appContext;
        }
        //Agregar
        Estilo IRepositorioEstilo.Add(Estilo estilo){
            var new_estilo = _appContext.estilo.Add(estilo);
            _appContext.SaveChanges();
            return new_estilo.Entity; //devuelve la entiendad completa que se guardo
        }
        //Eliminar
        void IRepositorioEstilo.Delete(int Idestilo){
            var estiloExiste = _appContext.estilo.FirstOrDefault(
                e => e.EstiloId == Idestilo
            );

            if (estiloExiste == null)
            return;
            _appContext.Remove(estiloExiste);
            _appContext.SaveChanges();
            
        }
        //Obtener todos los registros
        IEnumerable<Estilo> IRepositorioEstilo.GetAll(){
            return _appContext.estilo;
        }
        //Obtener un solo registro
        Estilo IRepositorioEstilo.Get(int Idestilo){
            return _appContext.estilo.FirstOrDefault(
                e => e.EstiloId == Idestilo
            );
        }
        //Actualizar
        Estilo IRepositorioEstilo.Update(Estilo estilo){
            var estiloEncontrado = _appContext.estilo.FirstOrDefault(
                e => e.EstiloId == estilo.EstiloId
            );
            if (estiloEncontrado != null)
            {
                estiloEncontrado.Nombre = estilo.Nombre;
                estiloEncontrado.Estado = estilo.Estado;
                /* estiloEncontrado.marca_ = estilo.marca_; */
            }
            _appContext.SaveChanges();
            return estiloEncontrado;
        }
    }
}