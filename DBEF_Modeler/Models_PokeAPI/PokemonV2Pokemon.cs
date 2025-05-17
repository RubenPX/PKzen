namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Pokemon
{
    public int Id { get; set; }

    public int? Order { get; set; }

    public int? Height { get; set; }

    public int? Weight { get; set; }

    public int? BaseExperience { get; set; }

    public bool IsDefault { get; set; }

    public int? PokemonSpeciesId { get; set; }

    public string Name { get; set; } = null!;

    public virtual PokemonV2Pokemonspecy? PokemonSpecies { get; set; }

    public virtual ICollection<PokemonV2Encounter> PokemonV2Encounters { get; set; } = new List<PokemonV2Encounter>();

    public virtual ICollection<PokemonV2Pokemonability> PokemonV2Pokemonabilities { get; set; } = new List<PokemonV2Pokemonability>();

    public virtual ICollection<PokemonV2Pokemonabilitypast> PokemonV2Pokemonabilitypasts { get; set; } = new List<PokemonV2Pokemonabilitypast>();

    public virtual ICollection<PokemonV2Pokemoncry> PokemonV2Pokemoncries { get; set; } = new List<PokemonV2Pokemoncry>();

    public virtual ICollection<PokemonV2Pokemonform> PokemonV2Pokemonforms { get; set; } = new List<PokemonV2Pokemonform>();

    public virtual ICollection<PokemonV2Pokemongameindex> PokemonV2Pokemongameindices { get; set; } = new List<PokemonV2Pokemongameindex>();

    public virtual ICollection<PokemonV2Pokemonitem> PokemonV2Pokemonitems { get; set; } = new List<PokemonV2Pokemonitem>();

    public virtual ICollection<PokemonV2Pokemonmove> PokemonV2Pokemonmoves { get; set; } = new List<PokemonV2Pokemonmove>();

    public virtual ICollection<PokemonV2Pokemonsprite> PokemonV2Pokemonsprites { get; set; } = new List<PokemonV2Pokemonsprite>();

    public virtual ICollection<PokemonV2Pokemonstat> PokemonV2Pokemonstats { get; set; } = new List<PokemonV2Pokemonstat>();

    public virtual ICollection<PokemonV2Pokemontypepast> PokemonV2Pokemontypepasts { get; set; } = new List<PokemonV2Pokemontypepast>();

    public virtual ICollection<PokemonV2Pokemontype> PokemonV2Pokemontypes { get; set; } = new List<PokemonV2Pokemontype>();
}
