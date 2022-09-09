using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dominio;

namespace persistencia
{
    public class RepositorioMarca : IRepositorioMarca
    {
        private readonly AplicationsContext _appContext;

        public RepositorioMarca(AplicationsContext appContext)
        {
            _appContext = appContext;
        }
        //Agregar
        Marca IRepositorioMarca.Add(Marca marca){
            var new_marca = _appContext.marca.Add(marca);
            _appContext.SaveChanges();
            return new_marca.Entity; //devuelve la entiendad completa que se guardo
        }
        //Eliminar
        void IRepositorioMarca.Delete(int Idmarca){
            var marcaExiste = _appContext.marca.FirstOrDefault(
                m => m.Id == Idmarca
            );

            if (marcaExiste == null)
            return;
            _appContext.Remove(Idmarca);
            _appContext.SaveChanges();
            
        }
        //Obtener todos los registros
        IEnumerable<Marca> IRepositorioMarca.GetAll(){
            return _appContext.marca;
        }
        //Obtener un solo registro
        Marca IRepositorioMarca.Get(int Idmarca){
            return _appContext.marca.FirstOrDefault(
                m => m.Id == Idmarca
            );
        }
        //Actualizar
        Marca IRepositorioMarca.Update(Marca marca){
            var marcaEncontrada = _appContext.marca.FirstOrDefault(
                m => m.Id == marca.Id
            );
            if (marcaEncontrada != null)
            {
                marcaEncontrada.Nombre = marca.Nombre;
                marcaEncontrada.Estado = marca.Estado;
            }
            _appContext.SaveChanges();
            return marcaEncontrada;
        }
    }
}