using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dominio;

namespace persistencia
{
    public class RepositorioUsuario : IRepositorioUsuario
    {
        private readonly AplicationsContext _appContext;

        public RepositorioUsuario(AplicationsContext appContext)
        {
            _appContext = appContext;
        }
        //Agregar
        Usuario IRepositorioUsuario.Add(Usuario usuario){
            var new_usuario = _appContext.usuario.Add(usuario);
            _appContext.SaveChanges();
            return new_usuario.Entity; //devuelve la entiendad completa qeu ser guardo
        }
        //Eliminar
        void IRepositorioUsuario.Delete(int Idusuario){
            var usuarioExiste = _appContext.usuario.FirstOrDefault(
                u => u.UsuarioId == Idusuario
            );

            if (usuarioExiste == null)
            return;
            _appContext.Remove(usuarioExiste);
            _appContext.SaveChanges();
            
        }
        //Obtener todos los registros
        IEnumerable<Usuario> IRepositorioUsuario.GetAll(){
            return _appContext.usuario;
        }
        //Obtener un solo registro
        Usuario IRepositorioUsuario.Get(int Idusuario){
            return _appContext.usuario.FirstOrDefault(
                u => u.UsuarioId == Idusuario
            );
        }
        //Actualizar
        Usuario IRepositorioUsuario.Update(Usuario usuario){
            var usuarioEncontrado = _appContext.usuario.FirstOrDefault(
                t => t.UsuarioId == usuario.UsuarioId
            );
            if (usuarioEncontrado != null)
            {
                usuarioEncontrado.Rol = usuario.Rol;
                usuarioEncontrado.User = usuario.User;
                usuarioEncontrado.Password = usuario.Password;
                usuarioEncontrado.Password = usuario.Password;
                usuarioEncontrado.Estado = usuario.Estado;
            }
            _appContext.SaveChanges();
            return usuarioEncontrado;
        }
    }
}