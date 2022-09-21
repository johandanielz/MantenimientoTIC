using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dominio;

namespace persistencia
{
    public interface IRepositorioEstilo
    {
        Estilo Add(Estilo estilo);
        Estilo Update(Estilo estilo);
        void Delete(int Idestilo);
        Estilo Get(int Idestilo);
        IEnumerable<Estilo> GetAll();
        IEnumerable<Estilo> GetEstadoTrue();
    }
}