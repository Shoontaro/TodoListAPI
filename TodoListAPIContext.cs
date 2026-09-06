using Microsoft.EntityFrameworkCore;
using TodoListAPI.Models;

public class TodoListAPIContext : DbContext
{
    public TodoListAPIContext(DbContextOptions<TodoListAPIContext> options) : base(options)
    {
    }
    public DbSet<Todo> Todo { get; set; }
    public DbSet<User> Users { get; set; }
}
