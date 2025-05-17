namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Pokemonitem
{
    public int Id { get; set; }

    public int Rarity { get; set; }

    public int? PokemonId { get; set; }

    public int? VersionId { get; set; }

    public int? ItemId { get; set; }

    public virtual PokemonV2Item? Item { get; set; }

    public virtual PokemonV2Pokemon? Pokemon { get; set; }

    public virtual PokemonV2Version? Version { get; set; }
}
