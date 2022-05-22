using ConcesionariaMVC1.Datos;

namespace ConcesionariaMVC1.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly ApplicationDbContext contexto;
        
        public Repository(ApplicationDbContext contexto)
        {
            this.contexto = contexto;
        }

        public void actualizar(T entity)
        {
            contexto.Set<T>().Update(entity);
        }

        public void agregar(T entity)
        {
            contexto.Set<T>().Add(entity);
        }

        public int cantidad()
        {
            return contexto.Set<T>().Count();
        }

        public void eliminar(int? id)
        {
            T entity = obtenerId(id);
            if (entity == null)
                throw new Exception("id no encontrado");
            contexto.Set<T>().Remove(entity);
        }

        public T obtenerId(int? id)
        {
            return contexto.Set<T>().Find(id);
        }

        public IEnumerable<T> obtenerTodos()
        {
            return (contexto.Set<T>()).ToList();
        }
    }
}
