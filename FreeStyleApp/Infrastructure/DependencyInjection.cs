using Microsoft.EntityFrameworkCore;

namespace FreeStyleApp.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        // Read from environment variables (injected by Docker)
        var host = configuration["POSTGRES_HOST"] ?? "localhost";
        var port = configuration["POSTGRES_PORT"] ?? "5432";
        var database = configuration["POSTGRES_DB"] ?? "free_style_app";
        var username = configuration["POSTGRES_USER"] ?? "postgres";
        var password = configuration["POSTGRES_PASSWORD"] ?? "";

        var connectionString = 
            $"Host={host};Port={port};Database={database};Username={username};Password={password}";

        Console.WriteLine($"🔌 Connecting to: Host={host}, Database={database}");

        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseNpgsql(connectionString));

        return services;
    }
}