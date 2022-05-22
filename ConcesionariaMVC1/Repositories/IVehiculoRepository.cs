using ConcesionariaMVC1.Models;

namespace ConcesionariaMVC1.Repositories
{
    public interface IVehiculoRepository
    {
        double obtenerPrecio(int? id);
    }
}
