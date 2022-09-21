using System.Net.Mime;
using System.Net.Sockets;
using System.ComponentModel.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dominio;

namespace persistencia
{
    public class RepositorioColor : IRepositorioColor
    {
        private readonly AplicationsContext _appContext;

        public RepositorioColor(AplicationsContext appContext)
        {
            _appContext = appContext;
        }
        //Agregar
        Color IRepositorioColor.Add(Color color){
            var new_color = _appContext.color.Add(color);
            _appContext.SaveChanges();
            return new_color.Entity; //devuelve la entiendad completa que se guardo
        }
        //Eliminar
        void IRepositorioColor.Delete(int Idcolor){
            var colorExiste = _appContext.color.FirstOrDefault(
                c => c.ColorId == Idcolor
            );

            if (colorExiste == null)
            return;
            _appContext.Remove(colorExiste);
            _appContext.SaveChanges();
            
        }
        //Obtener todos los registros
        IEnumerable<Color> IRepositorioColor.GetAll(){
            return _appContext.color;
        }
        IEnumerable<Color> IRepositorioColor.GetEstadoTrue(){
            return _appContext.color.Where(c => c.Estado == true).ToList();
        }
        //Obtener un solo registro
        Color IRepositorioColor.Get(int Idcolor){
            return _appContext.color.FirstOrDefault(
                c => c.ColorId == Idcolor
            );
        }
        //Actualizar
        Color IRepositorioColor.Update(Color color){
            var colorEncontrado = _appContext.color.FirstOrDefault(
                c => c.ColorId == color.ColorId
            );
            if (colorEncontrado != null)
            {
                colorEncontrado.Nombre = color.Nombre;
                colorEncontrado.Estado = color.Estado;
            }
            _appContext.SaveChanges();
            return colorEncontrado;
        }
    }
}