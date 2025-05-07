using Microsoft.EntityFrameworkCore;

namespace DataBaseBuilder.Entities;

public class Cries {
    public int Id { get; set; }
    public string Latest { get; set; }
    public string Legacy { get; set; }
    public int SpeciesId { get; set; }

    // Relación con Species
    public Species Species { get; set; }

    // Método estático para configurar la entidad
    public static void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.Entity<Cries>(entity => {
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Latest);
            entity.Property(c => c.Legacy);

            entity.HasOne(c => c.Species)
                .WithMany()
                .HasForeignKey(c => c.SpeciesId)
                .OnDelete(DeleteBehavior.Cascade);
        });
    }
}
