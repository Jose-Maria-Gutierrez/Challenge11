using ConcesionariaMVC1.Datos;
using ConcesionariaMVC1.Repositories;

namespace ConcesionariaMVC1.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext context;
        public IVehiculoRepository VehiculoRepository { get; }

        public UnitOfWork(ApplicationDbContext context, IVehiculoRepository vehiculoRepository)
        {
            this.context = context;
            this.VehiculoRepository = vehiculoRepository;
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public void guardar()
        {
            this.context.SaveChanges();
        }
    }
}
