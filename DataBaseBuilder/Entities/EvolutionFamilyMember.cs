using Microsoft.EntityFrameworkCore;

namespace DataBaseBuilder.Entities;

public class EvolutionFamilyMember
{
    public int Id { get; set; }
    public int? PokemonEvolutionId { get; set; }
    public string Name { get; set; }
    public string? Gender { get; set; }
    public string? HeldItem { get; set; }
    public string? Item { get; set; }
    public string? KnownMove { get; set; }
    public string? KnownMoveType { get; set; }
    public string? Location { get; set; }
    public int? MinAffection { get; set; }
    public int? MinBeauty { get; set; }
    public int? MinHappiness { get; set; }
    public int? MinLevel { get; set; }
    public bool? NeedsOverworldRain { get; set; }
    public string? PartySpecies { get; set; }
    public string? PartyType { get; set; }
    public string? RelativePhysicalStats { get; set; }
    public string? TimeOfDay { get; set; }
    public string? TradeSpecies { get; set; }
    public string? EvolutionTrigger { get; set; }
    public bool? TurnUpsideDown { get; set; }
    public int EvolutionChainId { get; set; }

    // Relación con EvolutionChain
    public EvolutionChain EvolutionChain { get; set; }

    // Método estático para configurar la entidad
    public static void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EvolutionFamilyMember>(entity =>
        {
            entity.HasKey(efm => efm.Id);

            entity.Property(efm => efm.Name).IsRequired();

            entity.HasOne(efm => efm.EvolutionChain)
                .WithMany()
                .HasForeignKey(efm => efm.EvolutionChainId)
                .OnDelete(DeleteBehavior.Cascade);
        });
    }
}