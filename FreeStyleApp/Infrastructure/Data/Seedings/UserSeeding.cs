using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Entities;

namespace FreeStyleApp.Infrastructure.Data.Seeding;

public static class UserSeeding
{
    public static void SeedUsers(this EntityTypeBuilder<User> builder)
    {
       builder.HasData(
            new User 
            { 
                Id = Guid.Parse("11111111-1111-1111-1111-111111111111"), // Use specific GUID
                Name = "Admin User", 
                Email = "admin@freestyle.com",
                CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                CreatedBy = "System",
                IsDeleted = false
            },
            new User 
            { 
                Id = Guid.Parse("22222222-2222-2222-2222-222222222222"), // Use specific GUID
                Name = "Test User", 
                Email = "test@freestyle.com",
                CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                CreatedBy = "System",
                IsDeleted = false
            }
        );
    }
}