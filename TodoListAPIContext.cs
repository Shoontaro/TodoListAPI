using Microsoft.EntityFrameworkCore;

public class TodoListAPIContext(DbContextOptions<TodoListAPIContext> options) : DbContext(options)
{
    public DbSet<TodoListAPI.Models.Todo> Todo { get; set; } = default!;
}
