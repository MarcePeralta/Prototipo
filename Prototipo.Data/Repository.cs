namespace Prototipo.Data;
public class Repository<T> : IRepository<T> where T : Entity
{
    public T Add(T entity)
    {
        var obj = ((T)entity);
        obj.CreatedBy = "string.Empty";
        obj.DateCreated = DateTime.Now;
        obj.ModifiedBy = "string.Empty";
        obj.DateModified = DateTime.Now;
        obj.IsDeleted = false;

        return obj;
    }
}
