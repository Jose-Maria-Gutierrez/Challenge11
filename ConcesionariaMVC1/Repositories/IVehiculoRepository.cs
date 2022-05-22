using ConcesionariaMVC1.Models;

namespace ConcesionariaMVC1.Repositories
{
    public interface IVehiculoRepository : IRepository<Vehiculo>
    {
        double obtenerPrecio(int? id);
    }
}
