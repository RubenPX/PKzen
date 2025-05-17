namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Move
{
    public int Id { get; set; }

    public int? Power { get; set; }

    public int? Pp { get; set; }

    public int? Accuracy { get; set; }

    public int? Priority { get; set; }

    public int? MoveEffectChance { get; set; }

    public int? GenerationId { get; set; }

    public int? MoveDamageClassId { get; set; }

    public int? MoveEffectId { get; set; }

    public int? MoveTargetId { get; set; }

    public int? TypeId { get; set; }

    public int? ContestEffectId { get; set; }

    public int? ContestTypeId { get; set; }

    public int? SuperContestEffectId { get; set; }

    public string Name { get; set; } = null!;

    public virtual PokemonV2Contesteffect? ContestEffect { get; set; }

    public virtual PokemonV2Contesttype? ContestType { get; set; }

    public virtual PokemonV2Generation? Generation { get; set; }

    public virtual PokemonV2Movedamageclass? MoveDamageClass { get; set; }

    public virtual PokemonV2Moveeffect? MoveEffect { get; set; }

    public virtual PokemonV2Movetarget? MoveTarget { get; set; }

    public virtual ICollection<PokemonV2Contestcombo> PokemonV2ContestcomboFirstMoves { get; set; } = new List<PokemonV2Contestcombo>();

    public virtual ICollection<PokemonV2Contestcombo> PokemonV2ContestcomboSecondMoves { get; set; } = new List<PokemonV2Contestcombo>();

    public virtual ICollection<PokemonV2Machine> PokemonV2Machines { get; set; } = new List<PokemonV2Machine>();

    public virtual ICollection<PokemonV2Moveattributemap> PokemonV2Moveattributemaps { get; set; } = new List<PokemonV2Moveattributemap>();

    public virtual ICollection<PokemonV2Movechange> PokemonV2Movechanges { get; set; } = new List<PokemonV2Movechange>();

    public virtual ICollection<PokemonV2Moveflavortext> PokemonV2Moveflavortexts { get; set; } = new List<PokemonV2Moveflavortext>();

    public virtual ICollection<PokemonV2Movemetastatchange> PokemonV2Movemetastatchanges { get; set; } = new List<PokemonV2Movemetastatchange>();

    public virtual PokemonV2Movemetum? PokemonV2Movemetum { get; set; }

    public virtual ICollection<PokemonV2Movename> PokemonV2Movenames { get; set; } = new List<PokemonV2Movename>();

    public virtual ICollection<PokemonV2Pokemonevolution> PokemonV2Pokemonevolutions { get; set; } = new List<PokemonV2Pokemonevolution>();

    public virtual ICollection<PokemonV2Pokemonmove> PokemonV2Pokemonmoves { get; set; } = new List<PokemonV2Pokemonmove>();

    public virtual ICollection<PokemonV2Supercontestcombo> PokemonV2SupercontestcomboFirstMoves { get; set; } = new List<PokemonV2Supercontestcombo>();

    public virtual ICollection<PokemonV2Supercontestcombo> PokemonV2SupercontestcomboSecondMoves { get; set; } = new List<PokemonV2Supercontestcombo>();

    public virtual PokemonV2Supercontesteffect? SuperContestEffect { get; set; }

    public virtual PokemonV2Type? Type { get; set; }
}
