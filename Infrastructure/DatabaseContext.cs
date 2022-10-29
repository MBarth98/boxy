using System.Diagnostics.CodeAnalysis;
using Domain;
using Microsoft.EntityFrameworkCore;
using UnitsNet;

namespace Infrastructure;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> opts) : base(opts) 
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var entity = modelBuilder.Entity<Box>();

        entity.Property(p => p.Id).ValueGeneratedOnAdd();
        
        entity.Property(p => p.Price);
        entity.Property(p => p.Quantity);
        entity.Property(p => p.ImageUrl);
        entity.Property(p => p.Description);

        entity.Property(p => p.Tags).HasConversion(
            v => string.Join(',', v),
            v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList()
        );

        entity.Property(p => p.Height).HasConversion(
            v => v.Centimeters,
            v => Length.FromCentimeters(v)
        );

        entity.Property(p => p.Width).HasConversion(
            v => v.Centimeters,
            v => Length.FromCentimeters(v)
        );

        entity.Property(p => p.Depth).HasConversion(
            v => v.Centimeters,
            v => Length.FromCentimeters(v)
        );

        entity.Property(p => p.Thickness).HasConversion(
            v => v.Millimeters,
            v => Length.FromMillimeters(v)
        );

        entity.Property(p => p.Weight).HasConversion(
            v => v.Kilograms,
            v => Mass.FromKilograms(v)
        );

        base.OnModelCreating(modelBuilder);
    } 
    
    [AllowNull]
    public DbSet<Box> ProductTable { get; set; }
}