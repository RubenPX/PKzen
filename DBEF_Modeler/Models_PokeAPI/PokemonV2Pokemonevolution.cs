namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Pokemonevolution
{
    public int Id { get; set; }

    public int? MinLevel { get; set; }

    public string? TimeOfDay { get; set; }

    public int? MinHappiness { get; set; }

    public int? MinAffection { get; set; }

    public int? RelativePhysicalStats { get; set; }

    public bool NeedsOverworldRain { get; set; }

    public bool TurnUpsideDown { get; set; }

    public int? EvolutionTriggerId { get; set; }

    public int? EvolvedSpeciesId { get; set; }

    public int? GenderId { get; set; }

    public int? KnownMoveId { get; set; }

    public int? KnownMoveTypeId { get; set; }

    public int? PartySpeciesId { get; set; }

    public int? PartyTypeId { get; set; }

    public int? TradeSpeciesId { get; set; }

    public int? MinBeauty { get; set; }

    public int? EvolutionItemId { get; set; }

    public int? HeldItemId { get; set; }

    public int? LocationId { get; set; }

    public virtual PokemonV2Item? EvolutionItem { get; set; }

    public virtual PokemonV2Evolutiontrigger? EvolutionTrigger { get; set; }

    public virtual PokemonV2Pokemonspecy? EvolvedSpecies { get; set; }

    public virtual PokemonV2Gender? Gender { get; set; }

    public virtual PokemonV2Item? HeldItem { get; set; }

    public virtual PokemonV2Move? KnownMove { get; set; }

    public virtual PokemonV2Type? KnownMoveType { get; set; }

    public virtual PokemonV2Location? Location { get; set; }

    public virtual PokemonV2Pokemonspecy? PartySpecies { get; set; }

    public virtual PokemonV2Type? PartyType { get; set; }

    public virtual PokemonV2Pokemonspecy? TradeSpecies { get; set; }
}
