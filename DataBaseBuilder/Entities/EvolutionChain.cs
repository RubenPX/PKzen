using Microsoft.EntityFrameworkCore;

namespace DataBaseBuilder.Entities;

public class EvolutionChain {
    public int Id { get; set; }
    public string? BabyTriggerItem { get; set; }
    public int SpeciesId { get; set; }

    // Relación con Species
    public Species Species { get; set; }

    // Método estático para configurar la entidad
    public static void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.Entity<EvolutionChain>(entity => {
            entity.HasKey(ec => ec.Id);

            entity.Property(ec => ec.BabyTriggerItem);

            entity.HasOne(ec => ec.Species)
                .WithMany()
                .HasForeignKey(ec => ec.SpeciesId)
                .OnDelete(DeleteBehavior.Cascade);
        });
    }
}
