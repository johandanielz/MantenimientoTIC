using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dominio;

namespace persistencia
{
    public interface IRepositorioUsuario
    {
        Usuario Add(Usuario usuario);
        Usuario Update(Usuario usuario);
        void Delete(int Idusuario);
        Usuario Get(int Idusuario);
        IEnumerable<Usuario> GetAll();
    }
}