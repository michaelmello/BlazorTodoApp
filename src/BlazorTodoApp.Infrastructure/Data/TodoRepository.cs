using BlazorTodoApp.Core.Entities.TodoAggregate;
using BlazorTodoApp.Core.Interfaces;

namespace BlazorTodoApp.Infrastructure.Data;

public class TodoRepository : EfRepository<TodoList>, ITodoRepository
{
    public TodoRepository(TodoContext db) : base(db)
    {
    }

    public Task<TodoList> GetByIdWithItemsAsync(int id)
    {
        throw new NotImplementedException();
    }
}