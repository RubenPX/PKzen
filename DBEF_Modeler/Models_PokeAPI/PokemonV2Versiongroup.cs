namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Versiongroup
{
    public int Id { get; set; }

    public int? Order { get; set; }

    public int? GenerationId { get; set; }

    public string Name { get; set; } = null!;

    public virtual PokemonV2Generation? Generation { get; set; }

    public virtual ICollection<PokemonV2Abilitychange> PokemonV2Abilitychanges { get; set; } = new List<PokemonV2Abilitychange>();

    public virtual ICollection<PokemonV2Abilityflavortext> PokemonV2Abilityflavortexts { get; set; } = new List<PokemonV2Abilityflavortext>();

    public virtual ICollection<PokemonV2Encounterslot> PokemonV2Encounterslots { get; set; } = new List<PokemonV2Encounterslot>();

    public virtual ICollection<PokemonV2Itemflavortext> PokemonV2Itemflavortexts { get; set; } = new List<PokemonV2Itemflavortext>();

    public virtual ICollection<PokemonV2Machine> PokemonV2Machines { get; set; } = new List<PokemonV2Machine>();

    public virtual ICollection<PokemonV2Movechange> PokemonV2Movechanges { get; set; } = new List<PokemonV2Movechange>();

    public virtual ICollection<PokemonV2Moveeffectchange> PokemonV2Moveeffectchanges { get; set; } = new List<PokemonV2Moveeffectchange>();

    public virtual ICollection<PokemonV2Moveflavortext> PokemonV2Moveflavortexts { get; set; } = new List<PokemonV2Moveflavortext>();

    public virtual ICollection<PokemonV2Pokedexversiongroup> PokemonV2Pokedexversiongroups { get; set; } = new List<PokemonV2Pokedexversiongroup>();

    public virtual ICollection<PokemonV2Pokemonform> PokemonV2Pokemonforms { get; set; } = new List<PokemonV2Pokemonform>();

    public virtual ICollection<PokemonV2Pokemonmove> PokemonV2Pokemonmoves { get; set; } = new List<PokemonV2Pokemonmove>();

    public virtual ICollection<PokemonV2Versiongroupmovelearnmethod> PokemonV2Versiongroupmovelearnmethods { get; set; } = new List<PokemonV2Versiongroupmovelearnmethod>();

    public virtual ICollection<PokemonV2Versiongroupregion> PokemonV2Versiongroupregions { get; set; } = new List<PokemonV2Versiongroupregion>();

    public virtual ICollection<PokemonV2Version> PokemonV2Versions { get; set; } = new List<PokemonV2Version>();
}
