namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Contesttype
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual PokemonV2Berryflavor? PokemonV2Berryflavor { get; set; }

    public virtual ICollection<PokemonV2Contesttypename> PokemonV2Contesttypenames { get; set; } = new List<PokemonV2Contesttypename>();

    public virtual ICollection<PokemonV2Move> PokemonV2Moves { get; set; } = new List<PokemonV2Move>();
}
