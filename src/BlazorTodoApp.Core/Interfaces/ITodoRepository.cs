using BlazorTodoApp.Core.Entities.TodoAggregate;

namespace BlazorTodoApp.Core.Interfaces;

public interface ITodoRepository : IAsyncRepository<TodoList>
{
    Task<TodoList> GetByIdWithItemsAsync(int id);
}