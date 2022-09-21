using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using dominio;

namespace persistencia
{
    public interface IRepositorioRevOperaciones
    {
        RevOperaciones Add(RevOperaciones revOperaciones);
        RevOperaciones Update(RevOperaciones revOperaciones);
        void Delete(int IdrevOperaciones);
        RevOperaciones Get(int IdrevOperaciones);
        IEnumerable<RevOperaciones> GetAll();
    }
}