using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dominio;

namespace persistencia
{
    public class RepositorioRepuesto : IRepositorioRepuesto
    {
        private readonly AplicationsContext _appContext;

        public RepositorioRepuesto(AplicationsContext appContext)
        {
            _appContext = appContext;
        }
        //Agregar
        Repuesto IRepositorioRepuesto.Add(Repuesto repuesto){
            var new_repuesto = _appContext.repuesto.Add(repuesto);
            _appContext.SaveChanges();
            return new_repuesto.Entity; //devuelve la entiendad completa qeu ser guardo
        }
        //Eliminar
        void IRepositorioRepuesto.Delete(int Idrepuesto){
            var repuestoExiste = _appContext.repuesto.FirstOrDefault(
                r => r.Id == Idrepuesto
            );

            if (repuestoExiste == null)
            return;
            _appContext.Remove(Idrepuesto);
            _appContext.SaveChanges();
            
        }
        //Obtener todos los registros
        IEnumerable<Repuesto> IRepositorioRepuesto.GetAll(){
            return _appContext.repuesto;
        }
        //Obtener un solo registro
        Repuesto IRepositorioRepuesto.Get(int Idrepuesto){
            return _appContext.repuesto.FirstOrDefault(
                r => r.Id == Idrepuesto
            );
        }
        //Actualizar
        Repuesto IRepositorioRepuesto.Update(Repuesto repuesto){
            var repuestoEncontrado = _appContext.repuesto.FirstOrDefault(
                r => r.Id == repuesto.Id
            );
            if (repuestoEncontrado != null)
            {
                repuestoEncontrado.Referencia = repuesto.Referencia;
                repuestoEncontrado.Producto = repuesto.Producto;
                repuestoEncontrado.Tipo = repuesto.Tipo;
                repuestoEncontrado.Costo = repuesto.Costo;
                repuestoEncontrado.Precio = repuesto.Precio;
                repuestoEncontrado.Cantidad = repuesto.Cantidad;
                repuestoEncontrado.Estado = repuesto.Estado;
                repuestoEncontrado.grupo_ = repuesto.grupo_;
            }
            _appContext.SaveChanges();
            return repuestoEncontrado;
        }
    }
}