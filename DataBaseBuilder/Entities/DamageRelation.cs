using Microsoft.EntityFrameworkCore;

namespace DataBaseBuilder.Entities;

public class DamageRelation {
    public int SpeciesId { get; set; }
    public int TypeId { get; set; }
    public double RelationType { get; set; }
    public Species Species { get; set; }
    public Type Type { get; set; }

    public static void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.Entity<DamageRelation>(entity => {
            entity.HasKey(dr => new { dr.SpeciesId, dr.TypeId });

            entity.Property(dr => dr.RelationType).IsRequired();

            entity.HasOne(dr => dr.Species)
                .WithMany()
                .HasForeignKey(dr => dr.SpeciesId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(dr => dr.Type)
                .WithMany()
                .HasForeignKey(dr => dr.TypeId)
                .OnDelete(DeleteBehavior.Cascade);
        });
    }
}
