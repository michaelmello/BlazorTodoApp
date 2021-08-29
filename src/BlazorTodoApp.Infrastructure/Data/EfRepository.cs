using BlazorTodoApp.Core.Entities;
using BlazorTodoApp.Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlazorTodoApp.Infrastructure.Data;

public class EfRepository<T> : IAsyncRepository<T> where T : BaseEntity, IAggregateRoot
{
    protected readonly TodoContext _db;

    public EfRepository(TodoContext db)
    {
        _db = db;
    }

    public async Task<T> AddAsync(T entity)
    {
        await _db.Set<T>().AddAsync(entity);
        await _db.SaveChangesAsync();

        return entity;
    }

    public Task<T> DeleteAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _db.Set<T>().ToListAsync();
    }

    public Task<T> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<T> UpdateAsync(T entity)
    {
        throw new NotImplementedException();
    }
}