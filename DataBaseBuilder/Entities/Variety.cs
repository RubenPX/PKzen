using Microsoft.EntityFrameworkCore;

namespace DataBaseBuilder.Entities;

public class Variety
{
    public int Id { get; set; }
    public bool IsDefault { get; set; }
    public string Name { get; set; }
    public int SpeciesId { get; set; }

    // Relación con Species
    public Species Species { get; set; }

    // Método estático para configurar la entidad
    public static void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Variety>(entity =>
        {
            entity.HasKey(v => v.Id);

            entity.Property(v => v.IsDefault).IsRequired();
            entity.Property(v => v.Name).IsRequired();

            entity.HasOne(v => v.Species)
                .WithMany()
                .HasForeignKey(v => v.SpeciesId)
                .OnDelete(DeleteBehavior.Cascade);
        });
    }
}