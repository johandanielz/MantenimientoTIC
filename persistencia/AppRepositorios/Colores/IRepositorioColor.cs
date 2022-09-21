using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        IEnumerable<Color> GetEstadoTrue();
    }
}