namespace BlazorTodoApp.Core.Entities;

public class Todo : BaseEntity
{
    public string Title { get; set; }
    public bool IsComplete { get; set; }

    public Todo(string title) => Title = title;
}