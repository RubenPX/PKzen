using Microsoft.EntityFrameworkCore;

namespace DataBaseBuilder.Entities;

public class PokemonAbility
{
    public int PokemonId { get; set; }
    public int AbilityId { get; set; }

    // Relación con Pokemon
    public Pokemon Pokemon { get; set; }

    // Relación con Ability
    public Ability Ability { get; set; }

    // Método estático para configurar la entidad
    public static void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PokemonAbility>(entity =>
        {
            entity.HasKey(pa => new { pa.PokemonId, pa.AbilityId });

            entity.HasOne(pa => pa.Pokemon)
                .WithMany()
                .HasForeignKey(pa => pa.PokemonId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(pa => pa.Ability)
                .WithMany()
                .HasForeignKey(pa => pa.AbilityId)
                .OnDelete(DeleteBehavior.Cascade);
        });
    }
}