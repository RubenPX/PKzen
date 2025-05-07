using Microsoft.EntityFrameworkCore;

namespace DataBaseBuilder.Entities;

public class Move {
    public int Id { get; set; }
    public string Name { get; set; }
    public int? Accuracy { get; set; }
    public string? DamageClass { get; set; }
    public int? EffectChance { get; set; }
    public string? EffectText { get; set; }
    public int CritRate { get; set; }
    public int Drain { get; set; }
    public int FlinchChance { get; set; }
    public int Healing { get; set; }
    public int? MaxHits { get; set; }
    public int? MaxTurns { get; set; }
    public int? MinHits { get; set; }
    public int? MinTurns { get; set; }
    public int StatChance { get; set; }
    public int? Power { get; set; }
    public int Pp { get; set; }
    public int Priority { get; set; }
    public string? Target { get; set; }
    public int TypeId { get; set; }
    public int PokemonId { get; set; }

    // Relación con Type
    public Type Type { get; set; }

    // Relación con Pokemon (suponiendo que existe una entidad Pokemon)
    public Pokemon Pokemon { get; set; }

    // Método estático para configurar la entidad
    public static void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.Entity<Move>(entity => {
            entity.HasKey(m => m.Id);

            entity.Property(m => m.Name).IsRequired();
            entity.Property(m => m.Accuracy);
            entity.Property(m => m.DamageClass);
            entity.Property(m => m.EffectChance);
            entity.Property(m => m.EffectText);
            entity.Property(m => m.CritRate).IsRequired();
            entity.Property(m => m.Drain).IsRequired();
            entity.Property(m => m.FlinchChance).IsRequired();
            entity.Property(m => m.Healing).IsRequired();
            entity.Property(m => m.MaxHits);
            entity.Property(m => m.MaxTurns);
            entity.Property(m => m.MinHits);
            entity.Property(m => m.MinTurns);
            entity.Property(m => m.StatChance).IsRequired();
            entity.Property(m => m.Power);
            entity.Property(m => m.Pp).IsRequired();
            entity.Property(m => m.Priority).IsRequired();
            entity.Property(m => m.Target);

            entity.HasOne(m => m.Type)
                .WithMany()
                .HasForeignKey(m => m.TypeId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(m => m.Pokemon)
                .WithMany()
                .HasForeignKey(m => m.PokemonId)
                .OnDelete(DeleteBehavior.Cascade);
        });
    }
}
