using Microsoft.EntityFrameworkCore;

namespace DataBaseBuilder.Entities;

public class PokemonStat
{
    public int Id { get; set; }
    public int BaseStat { get; set; }
    public int Effort { get; set; }
    public int PokemonId { get; set; }
    public int StatId { get; set; }

    // Relación con Pokemon
    public Pokemon Pokemon { get; set; }

    // Relación con Stat (suponiendo que existe la entidad Stat)
    public Stat Stat { get; set; }

    // Método estático para configurar la entidad
    public static void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PokemonStat>(entity =>
        {
            entity.HasKey(ps => ps.Id);

            entity.Property(ps => ps.BaseStat).IsRequired();
            entity.Property(ps => ps.Effort).IsRequired();

            entity.HasOne(ps => ps.Pokemon)
                .WithMany()
                .HasForeignKey(ps => ps.PokemonId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(ps => ps.Stat)
                .WithMany()
                .HasForeignKey(ps => ps.StatId)
                .OnDelete(DeleteBehavior.Cascade);
        });
    }
}