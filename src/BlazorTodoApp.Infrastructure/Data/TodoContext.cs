using BlazorTodoApp.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorTodoApp.Infrastructure.Data;

public class TodoContext : DbContext
{
    public TodoContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Todo> Todos => Set<Todo>();
}