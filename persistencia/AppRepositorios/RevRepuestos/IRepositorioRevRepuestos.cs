using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dominio;

namespace persistencia
{
    public interface IRepositorioRevRepuestos
    {
        RevRepuestos Add(RevRepuestos revRepuestos);
        RevRepuestos Update(RevRepuestos revRepuestos);
        void Delete(int IdrevRepuestos);
        RevRepuestos Get(int IdrevRepuestos);
        IEnumerable<RevRepuestos> GetAll();
    }
}