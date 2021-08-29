using BlazorTodoApp.Core.Entities;

namespace BlazorTodoApp.Core.Interfaces;

public interface IAsyncRepository<T> where T : BaseEntity, IAggregateRoot
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<T> GetByIdAsync(int id);
    Task<T> AddAsync(T entity);
    Task<T> UpdateAsync(T entity);
    Task<T> DeleteAsync(T entity);
}