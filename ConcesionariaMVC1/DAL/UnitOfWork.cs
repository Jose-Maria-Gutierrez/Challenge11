using ConcesionariaMVC1.Datos;
using ConcesionariaMVC1.Repositories;

namespace ConcesionariaMVC1.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext context;
        private IVehiculoRepository vehiculoRepository;

        public UnitOfWork(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IVehiculoRepository VehiculoRepository
        {
            get
            {
                if (this.vehiculoRepository == null)
                    this.vehiculoRepository = new VehiculoRepository(this.context);
                
                return this.vehiculoRepository;
            }
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
