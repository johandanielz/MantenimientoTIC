using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dominio;

namespace persistencia
{
    public interface IRepositorioGrupoRepuesto
    {
        GrupoRepuesto Add(GrupoRepuesto grupoRepuesto);
        GrupoRepuesto Update(GrupoRepuesto grupoRepuesto);
        void Delete(int IdgrupoRepuesto);
        GrupoRepuesto Get(int IdgrupoRepuesto);
        IEnumerable<GrupoRepuesto> GetAll();
    }
}