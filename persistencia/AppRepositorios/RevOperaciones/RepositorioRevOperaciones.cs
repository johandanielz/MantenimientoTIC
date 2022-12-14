using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using dominio;

namespace persistencia
{
    public class RepositorioRevOperaciones : IRepositorioRevOperaciones
    {
        private readonly AplicationsContext _appContext;

        public RepositorioRevOperaciones(AplicationsContext appContext)
        {
            _appContext = appContext;
        }
        //Agregar
        RevOperaciones IRepositorioRevOperaciones.Add(RevOperaciones revOperaciones){
            var new_revOperaciones = _appContext.revOperaciones.Add(revOperaciones);
            _appContext.SaveChanges();
            return new_revOperaciones.Entity; //devuelve la entiendad completa qeu ser guardo
        }
        //Eliminar
        void IRepositorioRevOperaciones.Delete(int IdrevOperaciones){
            var revOperacionesExiste = _appContext.revOperaciones.Include(rop => rop.revision.vehiculo).Include(rop => rop.operacion).FirstOrDefault(
                ro => ro.RevOperacionesId == IdrevOperaciones
            );
            if (revOperacionesExiste == null)
            return;
            _appContext.Remove(revOperacionesExiste);
            _appContext.SaveChanges();
            
        }
        //Obtener todos los registros
        IEnumerable<RevOperaciones> IRepositorioRevOperaciones.GetAll(){
            return _appContext.revOperaciones.Include(rop => rop.revision.vehiculo).Include(rop => rop.operacion);
        }
        //Obtener un solo registro
        RevOperaciones IRepositorioRevOperaciones.Get(int IdrevOperaciones){
            return _appContext.revOperaciones.Include(rop => rop.revision.vehiculo).Include(rop => rop.operacion).FirstOrDefault(
                ro => ro.RevOperacionesId == IdrevOperaciones
            );
        }
        //Actualizar
        RevOperaciones IRepositorioRevOperaciones.Update(RevOperaciones revOperaciones){
            var revOperacionesEncontradas = _appContext.revOperaciones.FirstOrDefault(
                r => r.RevOperacionesId == revOperaciones.RevOperacionesId
            );
            if (revOperacionesEncontradas != null)
            {
                revOperacionesEncontradas.OperacionId = revOperaciones.OperacionId;
                revOperacionesEncontradas.RevisionId = revOperaciones.RevisionId;
            }
            _appContext.SaveChanges();
            return revOperacionesEncontradas;
        }
    }
}