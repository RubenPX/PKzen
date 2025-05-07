using Microsoft.EntityFrameworkCore;

namespace DataBaseBuilder.Entities;

public class Sprite {
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool Icon { get; set; }
    public string? BackMale { get; set; }
    public string? BackFemale { get; set; }
    public string? BackShiny { get; set; }
    public string? BackShinyFemale { get; set; }
    public string? FrontMale { get; set; }
    public string? FrontFemale { get; set; }
    public string? FrontShiny { get; set; }
    public string? FrontShinyFemale { get; set; }
    public int SpeciesId { get; set; }

    // Relación con Species
    public Species Species { get; set; }

    // Método estático para configurar la entidad
    public static void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.Entity<Sprite>(entity => {
            entity.HasKey(s => s.Id);

            entity.Property(s => s.Name);
            entity.Property(s => s.Icon).IsRequired();
            entity.Property(s => s.BackMale);
            entity.Property(s => s.BackFemale);
            entity.Property(s => s.BackShiny);
            entity.Property(s => s.BackShinyFemale);
            entity.Property(s => s.FrontMale);
            entity.Property(s => s.FrontFemale);
            entity.Property(s => s.FrontShiny);
            entity.Property(s => s.FrontShinyFemale);

            entity.HasOne(s => s.Species)
                .WithMany()
                .HasForeignKey(s => s.SpeciesId)
                .OnDelete(DeleteBehavior.Cascade);
        });
    }
}
