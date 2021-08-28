using BlazorTodoApp.Core.Entities;
using BlazorTodoApp.Core.Interfaces;

namespace BlazorTodoApp.Infrastructure.Data;

public class TodoRepository : EfRepository<Todo>, ITodoRepository
{
    public TodoRepository(TodoContext db) : base(db)
    {
    }
}