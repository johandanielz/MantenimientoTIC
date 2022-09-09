using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dominio;

namespace persistencia
{
    public class RepositorioGrupoRepuesto : IRepositorioGrupoRepuesto
    {
        private readonly AplicationsContext _appContext;

        public RepositorioGrupoRepuesto(AplicationsContext appContext)
        {
            _appContext = appContext;
        }
        //Agregar
        GrupoRepuesto IRepositorioGrupoRepuesto.Add(GrupoRepuesto grupoRepuesto){
            var new_grupoRepuesto = _appContext.grupoRepuesto.Add(grupoRepuesto);

            _appContext.SaveChanges();
            return new_grupoRepuesto.Entity; //devuelve la entiendad completa que se guardo
        }
        //Eliminar
        void IRepositorioGrupoRepuesto.Delete(int IdgrupoRepuesto){
            var grupoRepuestoExiste = _appContext.grupoRepuesto.FirstOrDefault(
                gr => gr.Id == IdgrupoRepuesto
            );

            if (grupoRepuestoExiste == null)
            return;
            _appContext.Remove(IdgrupoRepuesto);
            _appContext.SaveChanges();
            
        }
        //Obtener todos los registros
        IEnumerable<GrupoRepuesto> IRepositorioGrupoRepuesto.GetAll(){
            return _appContext.grupoRepuesto;
        }
        //Obtener un solo registro
        GrupoRepuesto IRepositorioGrupoRepuesto.Get(int IdgrupoRepuesto){
            return _appContext.grupoRepuesto.FirstOrDefault(
                gr => gr.Id == IdgrupoRepuesto
            );
        }
        //Actualizar
        GrupoRepuesto IRepositorioGrupoRepuesto.Update(GrupoRepuesto grupoRepuesto){
            var grupoRepuestoEncontrado = _appContext.grupoRepuesto.FirstOrDefault(
                gr => gr.Id == grupoRepuesto.Id
            );
            if (grupoRepuestoEncontrado != null)
            {
                grupoRepuestoEncontrado.Grupo = grupoRepuestoEncontrado.Grupo;
                grupoRepuestoEncontrado.Estado = grupoRepuestoEncontrado.Estado;
            }
            _appContext.SaveChanges();
            return grupoRepuestoEncontrado;
        }
    }
}