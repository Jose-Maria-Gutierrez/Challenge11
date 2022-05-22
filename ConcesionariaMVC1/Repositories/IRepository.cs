namespace ConcesionariaMVC1.Repositories
{
    public interface IRepository<T>
    {
        void agregar(T entity);
        void eliminar(int? id);
        void actualizar(T entity);
        int cantidad();
        T obtenerId(int? id);
        IEnumerable<T> obtenerTodos();
    }
}
