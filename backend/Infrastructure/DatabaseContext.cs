using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Domain;

namespace Infrastructure;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> opts) : base(opts) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var entity = modelBuilder.Entity<Box>();

        entity.Property(p => p.Id).ValueGeneratedOnAdd();
        
        entity.Property(p => p.Price);
        entity.Property(p => p.Quantity);
        entity.Property(p => p.ImageUrl);
        entity.Property(p => p.Description);

        entity.Property(p => p.Height);
        entity.Property(p => p.Width);
        entity.Property(p => p.Depth);
        entity.Property(p => p.Thickness);
        entity.Property(p => p.Weight);
        
        entity.Property(p => p.Tags).HasConversion(
            v => string.Join(',', v),
            v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList()
        );

        base.OnModelCreating(modelBuilder);
    } 
    
    [AllowNull]
    public DbSet<Box> ProductTable { get; set; }
}