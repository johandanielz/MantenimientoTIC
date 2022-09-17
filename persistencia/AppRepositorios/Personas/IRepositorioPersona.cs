using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dominio;

namespace persistencia
{
    public interface IRepositorioPersona
    {
        Persona Add(Persona persona);
        Persona Update(Persona persona);
        void Delete(int Idpersona);
        Persona Get(int Idpersona);
        IEnumerable<Persona> GetAll();
        Persona GetCedula(string Cedula);
       
    }
}