namespace TravelManagementAPI.Repository;

public interface IRepository<T> 
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<T> GetByIdAsync(int id);
    T Add(T entity);
    T Update(T entity);
    T Delete(T entity);
}
