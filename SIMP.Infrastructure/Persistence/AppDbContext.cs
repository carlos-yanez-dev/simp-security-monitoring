using Microsoft.EntityFrameworkCore;
using SIMP.Domain.Entities;

namespace SIMP.Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public DbSet<Incident> Incidents => Set<Incident>();
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {

        builder.Entity<Incident>(entity =>
        {
            entity.HasKey(x => x.Id);

            entity.Property(x => x.Title)
            .IsRequired()
            .HasMaxLength(200);

            entity.Property(x=>x.Description)
            .IsRequired();

            entity.Property(x=>x.Severity)
            .IsRequired();

            entity.Property(x=>x.Status)
            .IsRequired();
    
        });
    }
}