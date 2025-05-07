using Microsoft.EntityFrameworkCore;

namespace DataBaseBuilder.Entities;

public class Type
{
    public int Id { get; set; }
    public string Name { get; set; }

    // Método estático para configurar la entidad
    public static void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Type>(entity =>
        {
            entity.HasKey(t => t.Id);
            entity.Property(t => t.Name).IsRequired();
        });
    }
}