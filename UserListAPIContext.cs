using Microsoft.EntityFrameworkCore;

public class UserListAPIContext(DbContextOptions<UserListAPIContext> options) : DbContext(options)
{
    public DbSet<TodoListAPI.Models.User> User { get; set; } = default!;
}
