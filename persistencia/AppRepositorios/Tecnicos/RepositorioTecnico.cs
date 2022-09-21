using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using dominio;

namespace persistencia
{
    public class RepositorioTecnico : IRepositorioTecnico
    {
        private readonly AplicationsContext _appContext;

        public RepositorioTecnico(AplicationsContext appContext)
        {
            _appContext = appContext;
        }
        //Agregar
        Tecnico IRepositorioTecnico.Add(Tecnico tecnico){
            var new_tecnico = _appContext.tecnico.Add(tecnico);
            _appContext.SaveChanges();
            return new_tecnico.Entity; //devuelve la entiendad completa qeu ser guardo
        }
        //Eliminar
        void IRepositorioTecnico.Delete(int Idtecnico){
            var tecnicoExiste = _appContext.tecnico.Include(t => t.persona).Include(t => t.tipoVehiculo).FirstOrDefault(
                t => t.TecnicoId == Idtecnico
            );

            if (tecnicoExiste == null)
            return;
            _appContext.Remove(tecnicoExiste);
            _appContext.SaveChanges();
            
        }
        //Obtener todos los registros
        IEnumerable<Tecnico> IRepositorioTecnico.GetAll(){
            return _appContext.tecnico.Include(t => t.persona).Include(t => t.tipoVehiculo);
        }
        IEnumerable<Tecnico> IRepositorioTecnico.GetEstadoTrue(){
            return _appContext.tecnico.Where(t => t.Estado == true).ToList();
        }
        //Obtener un solo registro
        Tecnico IRepositorioTecnico.Get(int Idtecnico){
            return _appContext.tecnico.Include(t => t.persona).Include(t => t.tipoVehiculo).FirstOrDefault(
                t => t.TecnicoId == Idtecnico
            );
        }
        //Actualizar
        Tecnico IRepositorioTecnico.Update(Tecnico tecnico){
            var tecnicoEncontrado = _appContext.tecnico.FirstOrDefault(
                t => t.TecnicoId == tecnico.TecnicoId
            );
            if (tecnicoEncontrado != null)
            {
                tecnicoEncontrado.Estado = tecnico.Estado;
                tecnicoEncontrado.PersonaId = tecnico.PersonaId;
                tecnicoEncontrado.TipoVehiculoId = tecnico.TipoVehiculoId;
            }
            _appContext.SaveChanges();
            return tecnicoEncontrado;
        }
    }
}