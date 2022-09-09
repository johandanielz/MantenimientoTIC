using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dominio;

namespace persistencia
{
    public class RepositorioRevision : IRepositorioRevision
    {
        private readonly AplicationsContext _appContext;

        public RepositorioRevision(AplicationsContext appContext)
        {
            _appContext = appContext;
        }
        //Agregar
        Revision IRepositorioRevision.Add(Revision revision){
            var new_revision = _appContext.revision.Add(revision);
            _appContext.SaveChanges();
            return new_revision.Entity; //devuelve la entiendad completa qeu ser guardo
        }
        //Eliminar
        void IRepositorioRevision.Delete(int Idrevision){
            var revisionExiste = _appContext.revision.FirstOrDefault(
                r => r.Id == Idrevision
            );

            if (revisionExiste == null)
            return;
            _appContext.Remove(Idrevision);
            _appContext.SaveChanges();
            
        }
        //Obtener todos los registros
        IEnumerable<Revision> IRepositorioRevision.GetAll(){
            return _appContext.revision;
        }
        //Obtener un solo registro
        Revision IRepositorioRevision.Get(int Idrevision){
            return _appContext.revision.FirstOrDefault(
                r => r.Id == Idrevision
            );
        }
        //Actualizar
        Revision IRepositorioRevision.Update(Revision revision){
            var revisionEncontrada = _appContext.revision.FirstOrDefault(
                r => r.Id == revision.Id
            );
            if (revisionEncontrada != null)
            {
                revisionEncontrada.Fecha = revision.Fecha;
                revisionEncontrada.Kilometraje = revision.Kilometraje;
                revisionEncontrada.Estado_vehiculo = revision.Estado_vehiculo;
                revisionEncontrada.Fecha_inicio = revision.Fecha_inicio;
                revisionEncontrada.Fecha_fin = revision.Fecha_fin;
                revisionEncontrada.Estado = revision.Estado;
                revisionEncontrada.Sintomas = revision.Sintomas;
                revisionEncontrada.vehiculo_ = revision.vehiculo_;
                revisionEncontrada.tecnico_ = revision.tecnico_;
            }
            _appContext.SaveChanges();
            return revisionEncontrada;
        }
    }
}