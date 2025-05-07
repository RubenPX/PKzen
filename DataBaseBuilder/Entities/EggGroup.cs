using Microsoft.EntityFrameworkCore;

namespace DataBaseBuilder.Entities;

public class EggGroup
{
    public int Id { get; set; }
    public string Name { get; set; }

    // Método estático para configurar la entidad
    public static void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EggGroup>(entity =>
        {
            entity.HasKey(eg => eg.Id);
            entity.Property(eg => eg.Name).IsRequired();
        });
    }
}