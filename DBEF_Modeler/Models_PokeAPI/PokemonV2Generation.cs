namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Generation
{
    public int Id { get; set; }

    public int? RegionId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<PokemonV2Ability> PokemonV2Abilities { get; set; } = new List<PokemonV2Ability>();

    public virtual ICollection<PokemonV2Generationname> PokemonV2Generationnames { get; set; } = new List<PokemonV2Generationname>();

    public virtual ICollection<PokemonV2Itemgameindex> PokemonV2Itemgameindices { get; set; } = new List<PokemonV2Itemgameindex>();

    public virtual ICollection<PokemonV2Locationgameindex> PokemonV2Locationgameindices { get; set; } = new List<PokemonV2Locationgameindex>();

    public virtual ICollection<PokemonV2Move> PokemonV2Moves { get; set; } = new List<PokemonV2Move>();

    public virtual ICollection<PokemonV2Pokemonabilitypast> PokemonV2Pokemonabilitypasts { get; set; } = new List<PokemonV2Pokemonabilitypast>();

    public virtual ICollection<PokemonV2Pokemonformgeneration> PokemonV2Pokemonformgenerations { get; set; } = new List<PokemonV2Pokemonformgeneration>();

    public virtual ICollection<PokemonV2Pokemonspecy> PokemonV2Pokemonspecies { get; set; } = new List<PokemonV2Pokemonspecy>();

    public virtual ICollection<PokemonV2Pokemontypepast> PokemonV2Pokemontypepasts { get; set; } = new List<PokemonV2Pokemontypepast>();

    public virtual ICollection<PokemonV2Typeefficacypast> PokemonV2Typeefficacypasts { get; set; } = new List<PokemonV2Typeefficacypast>();

    public virtual ICollection<PokemonV2Typegameindex> PokemonV2Typegameindices { get; set; } = new List<PokemonV2Typegameindex>();

    public virtual ICollection<PokemonV2Type> PokemonV2Types { get; set; } = new List<PokemonV2Type>();

    public virtual ICollection<PokemonV2Versiongroup> PokemonV2Versiongroups { get; set; } = new List<PokemonV2Versiongroup>();

    public virtual PokemonV2Region? Region { get; set; }
}
