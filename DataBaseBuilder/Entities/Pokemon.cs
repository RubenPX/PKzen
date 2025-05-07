using Microsoft.EntityFrameworkCore;

namespace DataBaseBuilder.Entities;

public class Pokemon
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int BaseExperience { get; set; }
    public int Weight { get; set; }
    public int Height { get; set; }
    public bool IsShiny { get; set; }
    public string? Gender { get; set; }
    public int SpeciesId { get; set; }

    // Relación con Species
    public Species Species { get; set; }

    // Método estático para configurar la entidad
    public static void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Pokemon>(entity =>
        {
            entity.HasKey(p => p.Id);

            entity.Property(p => p.Name).IsRequired();
            entity.Property(p => p.BaseExperience).IsRequired();
            entity.Property(p => p.Weight).IsRequired();
            entity.Property(p => p.Height).IsRequired();
            entity.Property(p => p.IsShiny).IsRequired();
            entity.Property(p => p.Gender);

            entity.HasOne(p => p.Species)
                .WithMany()
                .HasForeignKey(p => p.SpeciesId)
                .OnDelete(DeleteBehavior.Cascade);
        });
    }
}