using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            var tecnicoExiste = _appContext.tecnico.FirstOrDefault(
                t => t.TecnicoId == Idtecnico
            );

            if (tecnicoExiste == null)
            return;
            _appContext.Remove(tecnicoExiste);
            _appContext.SaveChanges();
            
        }
        //Obtener todos los registros
        IEnumerable<Tecnico> IRepositorioTecnico.GetAll(){
            return _appContext.tecnico;
        }
        //Obtener un solo registro
        Tecnico IRepositorioTecnico.Get(int Idtecnico){
            return _appContext.tecnico.FirstOrDefault(
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
                tecnicoEncontrado.persona = tecnico.persona;
            }
            _appContext.SaveChanges();
            return tecnicoEncontrado;
        }
    }
}