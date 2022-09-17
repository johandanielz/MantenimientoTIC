using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using dominio;

namespace persistencia
{
    public interface IRepositorioColor
    {
        Color Add(Color color);
        Color Update(Color color);
        void Delete(int Idcolor);
        Color Get(int Idcolor);
        IEnumerable<Color> GetAll();
        List<SelectListItem> GetNombreColor();
        Color GetColorName(string nombre);
    }
}