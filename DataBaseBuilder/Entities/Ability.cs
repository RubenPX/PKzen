using Microsoft.EntityFrameworkCore;

namespace DataBaseBuilder.Entities;

public class Ability
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsHidden { get; set; }
    public bool IsSelected { get; set; }

    // Método estático para configurar la entidad
    internal static void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ability>(entity =>
        {
            entity.HasKey(a => a.Id);
            entity.Property(a => a.Name).IsRequired();
            entity.Property(a => a.IsHidden).IsRequired();
            entity.Property(a => a.IsSelected).HasDefaultValue(false);
        });
    }
}