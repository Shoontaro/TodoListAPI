namespace TodoListAPI.Models
{
    public class Todo
    {
        public int UserId { get; set; }
        public int TodoId { get; set; }
        public string? title { get; set; }
        public string? description { get; set; }
    }
}
