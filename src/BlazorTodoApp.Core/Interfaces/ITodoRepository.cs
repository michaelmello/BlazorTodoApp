using BlazorTodoApp.Core.Entities;

namespace BlazorTodoApp.Core.Interfaces;

public interface ITodoRepository : IAsyncRepository<Todo>
{
    
}