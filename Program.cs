using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("TodoListAPIContext") ?? throw new InvalidOperationException("Connection string 'TodoListAPIContext' not found.");

builder.Services.AddDbContext<TodoListAPIContext>(options =>
options.UseSqlServer(connectionString, 
    sqlOptions => sqlOptions.EnableRetryOnFailure(
            maxRetryCount: 5,
            maxRetryDelay: TimeSpan.FromSeconds(30),
            errorNumbersToAdd: null
        )));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

//using (var scope = app.Services.CreateScope())
//{
//    var dbContext = scope.ServiceProvider.GetRequiredService<TodoListAPIContext>();

//    // 1. Удаляем пустую базу, в которой нет таблиц
//    dbContext.Database.EnsureDeleted();

//    // 2. Создаем базу заново БАЗУ И ВСЕ ТАБЛИЦЫ (Users и TodoItems) с нуля
//    dbContext.Database.EnsureCreated();
//}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
