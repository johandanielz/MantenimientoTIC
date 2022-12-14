using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dominio;

namespace persistencia
{
    public class RepositorioPersona : IRepositorioPersona
    {
        private readonly AplicationsContext _appContext;

        public RepositorioPersona(AplicationsContext appContext)
        {
            _appContext = appContext;
        }
        //Agregar
        Persona IRepositorioPersona.Add(Persona persona){
            var new_persona = _appContext.persona.Add(persona);
            _appContext.SaveChanges();
            return new_persona.Entity; //devuelve la entiendad completa que ser guardo
        }
        //Eliminar
        void IRepositorioPersona.Delete(int Idpersona){
            var personaExiste = _appContext.persona.FirstOrDefault(
                p => p.PersonaId == Idpersona
            );

            if (personaExiste == null)
            return;
            _appContext.Remove(personaExiste);
            _appContext.SaveChanges();
            
        }
        //Obtener todos los registros
        IEnumerable<Persona> IRepositorioPersona.GetAll(){
            return _appContext.persona;
        }
        IEnumerable<Persona> IRepositorioPersona.GetPersonaTecnico(){
            return _appContext.persona.Where(p => p.Clasificacion == "Tecnico").ToList();
        }
        //Obtener un solo registro
        Persona IRepositorioPersona.Get(int Idpersona){
            return _appContext.persona.FirstOrDefault(
                p => p.PersonaId == Idpersona
            );
        }
        //Obtener un solo registro por cedula
        Persona IRepositorioPersona.GetCedula(string Cedula){
            return _appContext.persona.FirstOrDefault(
                p => p.Cedula == Cedula
            );
        }
        //Actualizar
        Persona IRepositorioPersona.Update(Persona persona){
            var personaEncontrada = _appContext.persona.FirstOrDefault(
                p => p.PersonaId == persona.PersonaId
            );
            if (personaEncontrada != null)
            {
                personaEncontrada.TipoDocumento = persona.TipoDocumento;
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