using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using dominio;

namespace persistencia
{
    public class RepositorioRevRepuestos : IRepositorioRevRepuestos
    {
        private readonly AplicationsContext _appContext;

        public RepositorioRevRepuestos(AplicationsContext appContext)
        {
            _appContext = appContext;
        }
        //Agregar
        RevRepuestos IRepositorioRevRepuestos.Add(RevRepuestos revRepuestos){
            var new_revRepuestos = _appContext.revRepuestos.Add(revRepuestos);
            _appContext.SaveChanges();
            return new_revRepuestos.Entity; //devuelve la entiendad completa qeu ser guardo
        }
        //Eliminar
        void IRepositorioRevRepuestos.Delete(int IdrevRepuestos){
            var revRepuestosExiste = _appContext.revRepuestos.Include(rop => rop.revision.vehiculo).Include(rop => rop.repuesto).FirstOrDefault(
                r => r.RevRepuestosId == IdrevRepuestos
            );

            if (revRepuestosExiste == null)
            return;
            _appContext.Remove(revRepuestosExiste);
            _appContext.SaveChanges();
            
        }
        //Obtener todos los registros
        IEnumerable<RevRepuestos> IRepositorioRevRepuestos.GetAll(){
            return _appContext.revRepuestos.Include(rop => rop.revision.vehiculo).Include(rop => rop.repuesto);
        }
        //Obtener un solo registro
        RevRepuestos IRepositorioRevRepuestos.Get(int IdrevRepuestos){
            return _appContext.revRepuestos.Include(rop => rop.revision.vehiculo).Include(rop => rop.repuesto).FirstOrDefault(
                r => r.RevRepuestosId == IdrevRepuestos
            );
        }
        //Actualizar
        RevRepuestos IRepositorioRevRepuestos.Update(RevRepuestos revRepuestos){
            var revRepuestosEncontrados = _appContext.revRepuestos.FirstOrDefault(
                r => r.RevRepuestosId == revRepuestos.RevRepuestosId
            );
            if (revRepuestosEncontrados != null)
            {
                revRepuestosEncontrados.RepuestoId = revRepuestos.RepuestoId;
                revRepuestosEncontrados.RevisionId = revRepuestos.RevisionId;
            }
            _appContext.SaveChanges();
            return revRepuestosEncontrados;
        }
    }
}