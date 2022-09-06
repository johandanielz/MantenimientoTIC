using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dominio;

namespace persistencia
{
    public class RepositorioPersona : IRepositorioPersona
    {
        private readonly AppContext _appContext;

        public RepositorioPersona(AppContext appContext)
        {
            _appContext = appContext;
        }
        //Agregar
        Persona IRepositorioPersona.Add(Persona persona){
            var new_persona = _appContext.persona.Add(persona);
            _appContext.SaveChanges();
            return new_persona.Entity; //devuelve la entiendad completa qeu ser guardo
        }
        //Eliminar
        void IRepositorioPersona.Delete(int Idpersona){
            var personaExiste = _appContext.persona.FirstOrDefault(
                p => p.Id == Idpersona
            );

            if (personaExiste == null)
            return;
            _appContext.Remove(Idpersona);
            _appContext.SaveChanges();
            
        }
        //Obtener todos los registros
        IEnumerable<Persona> IRepositorioPersona.GetAll(){
            return _appContext.persona;
        }
        //Obtener un solo registro
        Persona IRepositorioPersona.Get(int Idpersona){
            return _appContext.persona.FirstOrDefault(
                p => p.Id == Idpersona
            );
        }
        //Actualizar
        Persona IRepositorioPersona.Update(Persona persona){
            var personaEncontrada = _appContext.persona.FirstOrDefault(
                p => p.Id == persona.Id
            );
            if (personaEncontrada != null)
            {
                personaEncontrada.Cedula = persona.Cedula;
                personaEncontrada.Nombre = persona.Nombre;
                personaEncontrada.Apellido = persona.Apellido;
                personaEncontrada.Celular = persona.Celular;
                personaEncontrada.Correo = persona.Correo;
                personaEncontrada.Direccion = persona.Direccion;
                personaEncontrada.Clasificacion = persona.Clasificacion;
            }
            _appContext.SaveChanges();
            return personaEncontrada;
        }
    }
}