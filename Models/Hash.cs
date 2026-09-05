using BCrypt.Net;

namespace TodoListAPI.Models;

public static class Hash
{
    public static string GetHashCode(string password) {
        return BCrypt.Net.BCrypt.HashPassword(password);
    }

    public static bool VerifyPassword(string password, string hashedPassword)
    {
        // Метод сам извлечет соль из хэша и сравнит результаты
        return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
    }
}
