using FreeStyleApp.Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Register DbContext (like @Repository in Spring)
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("DefaultConnection")
    ));

// add controllers
builder.Services.AddControllers();


//builder.Services.AddOpenApi();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    try
    {
        var canConnect = await context.Database.CanConnectAsync();
        if (canConnect)
        {
            Console.WriteLine("Database connection successful!");
        }
        else
        {
            Console.WriteLine("Cannot connect to database!");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Database error: {ex.Message}");
    }
}

// Map controllers to routes
app.MapControllers();

app.Run();
