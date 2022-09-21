using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using dominio;

namespace persistencia
{
    public interface IRepositorioRevision
    {
        Revision Add(Revision revision);
        Revision Update(Revision revision);
        void Delete(int Idrevision);
        Revision Get(int Idrevision);
        IEnumerable<Revision> GetAll();
    }
}