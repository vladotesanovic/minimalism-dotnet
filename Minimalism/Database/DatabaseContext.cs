using Microsoft.EntityFrameworkCore;
using Minimalism.Database.Configuration;
using Minimalism.Domain.Entities;

namespace Minimalism.Database;

public class DatabaseContext : DbContext
{
    public DbSet<Spot> Spots { get; set; }
    public DbSet<Parking> Parkings { get; set; }
    private string DbPath { get; }

    public DatabaseContext()
    {
        const Environment.SpecialFolder folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        
        DbPath = Path.Join(path, "parking.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={DbPath}");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new SpotEntityTypeConfiguration());
    }
}