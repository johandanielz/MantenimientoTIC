using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dominio;
using Microsoft.EntityFrameworkCore;

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
                gr => gr.GrupoRepuestoId == IdgrupoRepuesto
            );

            if (grupoRepuestoExiste == null)
            return;
            _appContext.Remove(grupoRepuestoExiste);
            _appContext.SaveChanges();
            
        }
        //Obtener todos los registros
        IEnumerable<GrupoRepuesto> IRepositorioGrupoRepuesto.GetAll(){
            return _appContext.grupoRepuesto;
        }
        IEnumerable<GrupoRepuesto> IRepositorioGrupoRepuesto.GetEstadoTrue(){
            return _appContext.grupoRepuesto.Where(gr =>gr.Estado == true).ToList();
        }
        //Obtener un solo registro
        GrupoRepuesto IRepositorioGrupoRepuesto.Get(int IdgrupoRepuesto){
            return _appContext.grupoRepuesto.FirstOrDefault(
                gr => gr.GrupoRepuestoId == IdgrupoRepuesto
            );
        }
        //Actualizar
        GrupoRepuesto IRepositorioGrupoRepuesto.Update(GrupoRepuesto grupoRepuesto){
            var grupoRepuestoEncontrado = _appContext.grupoRepuesto.FirstOrDefault(
                gr => gr.GrupoRepuestoId == grupoRepuesto.GrupoRepuestoId
            );
            if (grupoRepuestoEncontrado != null)
            {
                grupoRepuestoEncontrado.Grupo = grupoRepuesto.Grupo;
                grupoRepuestoEncontrado.Estado = grupoRepuesto.Estado;
            }
            _appContext.SaveChanges();
            return grupoRepuestoEncontrado;
        }
    }
}