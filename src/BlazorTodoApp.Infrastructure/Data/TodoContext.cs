using BlazorTodoApp.Core.Entities.TodoAggregate;
using Microsoft.EntityFrameworkCore;

namespace BlazorTodoApp.Infrastructure.Data;

public class TodoContext : DbContext
{
    public TodoContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<TodoList> TodoLists => Set<TodoList>();
    public DbSet<TodoItem> TodoItems => Set<TodoItem>();
}