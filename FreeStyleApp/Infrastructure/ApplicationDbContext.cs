using Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace FreeStyleApp.Infrastructure;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Apply all configurations from the configurations folder
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        
        // Or apply specific configurations
        // modelBuilder.ApplyConfiguration(new UserConfiguration());
    }

}