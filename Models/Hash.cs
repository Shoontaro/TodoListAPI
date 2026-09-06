using BCrypt.Net;

namespace TodoListAPI.Models;

public static class Hash
{
    public static string GetHashCode(string password) {
        return BCrypt.Net.BCrypt.HashPassword(password);
    }

    public static bool VerifyPassword(string password, string hashedPassword)
    {
        return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
    }
}
