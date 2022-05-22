using ConcesionariaMVC1.Datos;
using ConcesionariaMVC1.Repositories;

namespace ConcesionariaMVC1.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext context;
        private VehiculoRepository vehiculoRepository;
        public UnitOfWork(ApplicationDbContext context)
        {
            this.context = context;
        }
        public VehiculoRepository VehiculoRepository
        {
            get
            {
                if (this.vehiculoRepository == null)
                    return new VehiculoRepository(this.context);
                else
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
