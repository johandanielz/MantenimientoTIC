using System.Net.Mime;
using System.Net.Sockets;
using System.ComponentModel.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
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
                c => c.Id == Idcolor
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
        List<SelectListItem> IRepositorioColor.GetNombreColor(){
            return _appContext.color.Select(c => new SelectListItem{
                Value=(c.Nombre).ToString(),
                Text=(c.Nombre)
            }).ToList();
        }
        //Obtener un solo registro
        Color IRepositorioColor.Get(int Idcolor){
            return _appContext.color.FirstOrDefault(
                c => c.Id == Idcolor
            );
        }
        Color IRepositorioColor.GetColorName(string nombre){
            return _appContext.color.FirstOrDefault(
                c => c.Nombre == nombre
            );
        }
        //Actualizar
        Color IRepositorioColor.Update(Color color){
            var colorEncontrado = _appContext.color.FirstOrDefault(
                c => c.Id == color.Id
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