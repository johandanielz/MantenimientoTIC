using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dominio;

namespace persistencia
{
    public interface IRepositorioRepuesto
    {
        Repuesto Add(Repuesto repuesto);
        Repuesto Update(Repuesto repuesto);
        void Delete(int Idrepuesto);
        Repuesto Get(int Idrepuesto);
        IEnumerable<Repuesto> GetAll();
    }
}