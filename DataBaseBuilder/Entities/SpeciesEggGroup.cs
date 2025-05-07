using Microsoft.EntityFrameworkCore;

namespace DataBaseBuilder.Entities;

public class SpeciesEggGroup {
    public int SpeciesId { get; set; }
    public int EggGroupId { get; set; }

    // Relación con Species
    public Species Species { get; set; }

    // Relación con EggGroup
    public EggGroup EggGroup { get; set; }

    // Método estático para configurar la entidad
    public static void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.Entity<SpeciesEggGroup>(entity => {
            entity.HasKey(seg => new { seg.SpeciesId, seg.EggGroupId });

            entity.HasOne(seg => seg.Species)
                .WithMany()
                .HasForeignKey(seg => seg.SpeciesId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(seg => seg.EggGroup)
                .WithMany()
                .HasForeignKey(seg => seg.EggGroupId)
                .OnDelete(DeleteBehavior.Cascade);
        });
    }
}
