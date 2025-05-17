namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Pokemonform
{
    public int Id { get; set; }

    public int? Order { get; set; }

    public bool IsDefault { get; set; }

    public bool IsBattleOnly { get; set; }

    public int? VersionGroupId { get; set; }

    public int? PokemonId { get; set; }

    public bool IsMega { get; set; }

    public int? FormOrder { get; set; }

    public string FormName { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual PokemonV2Pokemon? Pokemon { get; set; }

    public virtual ICollection<PokemonV2Pokemonformgeneration> PokemonV2Pokemonformgenerations { get; set; } = new List<PokemonV2Pokemonformgeneration>();

    public virtual ICollection<PokemonV2Pokemonformname> PokemonV2Pokemonformnames { get; set; } = new List<PokemonV2Pokemonformname>();

    public virtual ICollection<PokemonV2Pokemonformsprite> PokemonV2Pokemonformsprites { get; set; } = new List<PokemonV2Pokemonformsprite>();

    public virtual ICollection<PokemonV2Pokemonformtype> PokemonV2Pokemonformtypes { get; set; } = new List<PokemonV2Pokemonformtype>();

    public virtual PokemonV2Versiongroup? VersionGroup { get; set; }
}
