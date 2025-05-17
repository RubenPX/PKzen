namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Pokemoncry
{
    public int Id { get; set; }

    public string Cries { get; set; } = null!;

    public int? PokemonId { get; set; }

    public virtual PokemonV2Pokemon? Pokemon { get; set; }
}
