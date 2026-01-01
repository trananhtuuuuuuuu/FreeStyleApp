using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Entities;
using FreeStyleApp.Infrastructure.Data.Seeding;


namespace FreeStyleApp.Infrastructures.Data.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users");
        
        builder.HasKey(u => u.Id);
        
        builder.Property(u => u.Name)
            .IsRequired()
            .HasMaxLength(100);
            
        builder.Property(u => u.Email)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(u => u.Gender)
            .IsRequired()
            .HasMaxLength(6);    
        
        builder.SeedUsers();
    }
}