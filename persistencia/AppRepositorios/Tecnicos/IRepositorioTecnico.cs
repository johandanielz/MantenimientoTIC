using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dominio;

namespace persistencia
{
    public interface IRepositorioTecnico
    {
        Tecnico Add(Tecnico tecnico);
        Tecnico Update(Tecnico tecnico);
        void Delete(int Idtecnico);
        Tecnico Get(int Idtecnico);
        IEnumerable<Tecnico> GetAll();
    }
}