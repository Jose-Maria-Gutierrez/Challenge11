using ConcesionariaMVC1.Datos;
using ConcesionariaMVC1.Models;

namespace ConcesionariaMVC1.Repositories
{
    public class VehiculoRepository : Repository<Vehiculo>, IVehiculoRepository
    {
        public VehiculoRepository(ApplicationDbContext contexto) : base(contexto)
        {
        }

        public double obtenerPrecio(int? id)
        {
            Vehiculo v = base.contexto.Set<Vehiculo>().Find(id);
            if (v==null)
            {
                throw new Exception("id no encontrado");
            }
            return v.precio;
        }

    }
}
