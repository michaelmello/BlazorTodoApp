namespace BlazorTodoApp.Core.Entities;

public abstract class BaseEntity
{
    public virtual int Id { get; protected set; }
}