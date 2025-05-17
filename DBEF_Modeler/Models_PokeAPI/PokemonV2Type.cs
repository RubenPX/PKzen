namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Type
{
    public int Id { get; set; }

    public int? GenerationId { get; set; }

    public int? MoveDamageClassId { get; set; }

    public string Name { get; set; } = null!;

    public virtual PokemonV2Generation? Generation { get; set; }

    public virtual PokemonV2Movedamageclass? MoveDamageClass { get; set; }

    public virtual ICollection<PokemonV2Berry> PokemonV2Berries { get; set; } = new List<PokemonV2Berry>();

    public virtual ICollection<PokemonV2Movechange> PokemonV2Movechanges { get; set; } = new List<PokemonV2Movechange>();

    public virtual ICollection<PokemonV2Move> PokemonV2Moves { get; set; } = new List<PokemonV2Move>();

    public virtual ICollection<PokemonV2Pokemonevolution> PokemonV2PokemonevolutionKnownMoveTypes { get; set; } = new List<PokemonV2Pokemonevolution>();

    public virtual ICollection<PokemonV2Pokemonevolution> PokemonV2PokemonevolutionPartyTypes { get; set; } = new List<PokemonV2Pokemonevolution>();

    public virtual ICollection<PokemonV2Pokemonformtype> PokemonV2Pokemonformtypes { get; set; } = new List<PokemonV2Pokemonformtype>();

    public virtual ICollection<PokemonV2Pokemontypepast> PokemonV2Pokemontypepasts { get; set; } = new List<PokemonV2Pokemontypepast>();

    public virtual ICollection<PokemonV2Pokemontype> PokemonV2Pokemontypes { get; set; } = new List<PokemonV2Pokemontype>();

    public virtual ICollection<PokemonV2Typeefficacy> PokemonV2TypeefficacyDamageTypes { get; set; } = new List<PokemonV2Typeefficacy>();

    public virtual ICollection<PokemonV2Typeefficacy> PokemonV2TypeefficacyTargetTypes { get; set; } = new List<PokemonV2Typeefficacy>();

    public virtual ICollection<PokemonV2Typeefficacypast> PokemonV2TypeefficacypastDamageTypes { get; set; } = new List<PokemonV2Typeefficacypast>();

    public virtual ICollection<PokemonV2Typeefficacypast> PokemonV2TypeefficacypastTargetTypes { get; set; } = new List<PokemonV2Typeefficacypast>();

    public virtual ICollection<PokemonV2Typegameindex> PokemonV2Typegameindices { get; set; } = new List<PokemonV2Typegameindex>();

    public virtual ICollection<PokemonV2Typename> PokemonV2Typenames { get; set; } = new List<PokemonV2Typename>();

    public virtual ICollection<PokemonV2Typesprite> PokemonV2Typesprites { get; set; } = new List<PokemonV2Typesprite>();
}
