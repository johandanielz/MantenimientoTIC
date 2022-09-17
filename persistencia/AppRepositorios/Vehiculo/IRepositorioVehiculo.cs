using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dominio;
using Microsoft.EntityFrameworkCore;

namespace persistencia
{
    public interface IRepositorioVehiculo
    {
        Vehiculo Add(Vehiculo vehiculo);
        Vehiculo Update(Vehiculo vehiculo);
        void Delete(int Idvehiculo);
        Vehiculo Get(int Idvehiculo);
        IEnumerable<Vehiculo> GetAll();
        IEnumerable<Color> GetColorTrue();
    }
}