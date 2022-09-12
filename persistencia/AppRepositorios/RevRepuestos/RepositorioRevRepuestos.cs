using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            var revRepuestosExiste = _appContext.revRepuestos.FirstOrDefault(
                r => r.Id == IdrevRepuestos
            );

            if (revRepuestosExiste == null)
            return;
            _appContext.Remove(revRepuestosExiste);
            _appContext.SaveChanges();
            
        }
        //Obtener todos los registros
        IEnumerable<RevRepuestos> IRepositorioRevRepuestos.GetAll(){
            return _appContext.revRepuestos;
        }
        //Obtener un solo registro
        RevRepuestos IRepositorioRevRepuestos.Get(int IdrevRepuestos){
            return _appContext.revRepuestos.FirstOrDefault(
                r => r.Id == IdrevRepuestos
            );
        }
        //Actualizar
        RevRepuestos IRepositorioRevRepuestos.Update(RevRepuestos revRepuestos){
            var revRepuestosEncontrados = _appContext.revRepuestos.FirstOrDefault(
                r => r.Id == revRepuestos.Id
            );
            if (revRepuestosEncontrados != null)
            {
                revRepuestosEncontrados.repuesto_ = revRepuestos.repuesto_;
                revRepuestosEncontrados.revision_ = revRepuestos.revision_;
            }
            _appContext.SaveChanges();
            return revRepuestosEncontrados;
        }
    }
}