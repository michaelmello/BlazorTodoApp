using BlazorTodoApp.Core.Interfaces;

namespace BlazorTodoApp.Core.Entities.TodoAggregate;

public class TodoList : BaseEntity, IAggregateRoot
{
    public string Name { get; set; }
    public IList<TodoItem> TodoItems { get; set; } = null!;

    public TodoList(string name) => Name = name;
}