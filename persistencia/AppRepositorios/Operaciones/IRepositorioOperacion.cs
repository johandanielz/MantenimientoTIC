using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dominio;

namespace persistencia
{
    public interface IRepositorioOperacion
    {
        Operacion Add(Operacion operacion);
        Operacion Update(Operacion operacion);
        void Delete(int Idoperacion);
        Operacion Get(int Idoperacion);
        IEnumerable<Operacion> GetAll();
    }
}