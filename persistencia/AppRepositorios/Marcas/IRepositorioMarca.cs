using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dominio;

namespace persistencia
{
    public interface IRepositorioMarca
    {
        Marca Add(Marca marca);
        Marca Update(Marca marca);
        void Delete(int Idmarca);
        Marca Get(int Idmarca);
        IEnumerable<Marca> GetAll();
        IEnumerable<Marca> GetEstadoTrue();
    }
}