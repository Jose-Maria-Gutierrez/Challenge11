using ConcesionariaMVC1.Datos;
using ConcesionariaMVC1.Repositories;

namespace ConcesionariaMVC1.DAL
{
    public interface IUnitOfWork : IDisposable
    {
        IVehiculoRepository VehiculoRepository { get; }
        public void guardar();
    }
}
