namespace Prototipo.Repositories.Repositories;
public interface IRepository<T> where T : Entity
{
    T Add(T entity);
}
