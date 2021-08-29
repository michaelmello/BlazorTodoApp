namespace BlazorTodoApp.Core.Entities.TodoAggregate;

public class TodoItem : BaseEntity
{
    public string Title { get; set; }
    public bool IsComplete { get; set; }

    public int TodoListId { get; set; }
    public TodoList TodoList { get; set; } = null!;

    public TodoItem(string title) => Title = title;
}