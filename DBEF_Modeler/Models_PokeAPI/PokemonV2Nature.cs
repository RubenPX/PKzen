namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Nature
{
    public int Id { get; set; }

    public int GameIndex { get; set; }

    public int? DecreasedStatId { get; set; }

    public int? IncreasedStatId { get; set; }

    public int? HatesFlavorId { get; set; }

    public int? LikesFlavorId { get; set; }

    public string Name { get; set; } = null!;

    public virtual PokemonV2Stat? DecreasedStat { get; set; }

    public virtual PokemonV2Berryflavor? HatesFlavor { get; set; }

    public virtual PokemonV2Stat? IncreasedStat { get; set; }

    public virtual PokemonV2Berryflavor? LikesFlavor { get; set; }

    public virtual ICollection<PokemonV2Naturebattlestylepreference> PokemonV2Naturebattlestylepreferences { get; set; } = new List<PokemonV2Naturebattlestylepreference>();

    public virtual ICollection<PokemonV2Naturename> PokemonV2Naturenames { get; set; } = new List<PokemonV2Naturename>();

    public virtual ICollection<PokemonV2Naturepokeathlonstat> PokemonV2Naturepokeathlonstats { get; set; } = new List<PokemonV2Naturepokeathlonstat>();
}
