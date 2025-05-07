using Microsoft.EntityFrameworkCore;

namespace DataBaseBuilder.Entities;

public class SpeciesType {
    public int Id { get; set; }
    public int Slot { get; set; }
    public int SpeciesId { get; set; }
    public int TypeId { get; set; }

    // Relación con Species
    public Species Species { get; set; }

    // Relación con Type
    public Type Type { get; set; }

    // Método estático para configurar la entidad
    public static void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.Entity<SpeciesType>(entity => {
            entity.HasKey(st => st.Id);

            entity.Property(st => st.Slot).IsRequired();

            entity.HasOne(st => st.Species)
                .WithMany()
                .HasForeignKey(st => st.SpeciesId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(st => st.Type)
                .WithMany()
                .HasForeignKey(st => st.TypeId)
                .OnDelete(DeleteBehavior.Cascade);
        });
    }
}
