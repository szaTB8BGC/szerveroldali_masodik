using LabEquipmentApi.Domain;
using Microsoft.EntityFrameworkCore;

namespace LabEquipmentApiData;

public class LabDbContext : DbContext
{
    public DbSet<Equipment> EquipmentItems => Set<Equipment>();
    public LabDbContext(DbContextOptions<LabDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Equipment>().HasData(
    new Equipment { Id = 1, Name = "Projektor",Room= "Lab10", IsAvailable = true },
    new Equipment { Id = 2, Name = "Laptop",Room= "Lab10", IsAvailable = false},
    new Equipment { Id = 3, Name = "Monitor",Room= "Lab11", IsAvailable = true }


);
    } 
}