using Microsoft.EntityFrameworkCore;

namespace DataBaseBuilder.Entities;

public class Stat
{
    public int Id { get; set; }
    public string Name { get; set; }

    // Método estático para configurar la entidad
    public static void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Stat>(entity =>
        {
            entity.HasKey(s => s.Id);

            entity.Property(s => s.Name).IsRequired();
        });
    }
}