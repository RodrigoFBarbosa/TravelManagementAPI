using Microsoft.EntityFrameworkCore;
using TravelManagementAPI.Context;

namespace TravelManagementAPI.Repository;

public class Repository<T> : IRepository<T> where T : class
{
    protected readonly AppDbContext _context;
    protected readonly DbSet<T> _dbSet;

    public Repository(AppDbContext context)
    {
        _context = context;
        _dbSet = context.Set<T>();
        
    }

    public T Add(T entity)
    {
        _dbSet.Add(entity);
        return entity;
    }

    public T Delete(T entity)
    {
        _dbSet.Remove(entity);
        return entity;
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
       return await _dbSet.AsNoTracking().ToListAsync();
    }

    public async Task<T> GetByIdAsync(int id)
    {
        return await _dbSet.FindAsync(id);
    }

    public T Update(T entity)
    {
         _dbSet.Update(entity);
        return entity;
    }
}
