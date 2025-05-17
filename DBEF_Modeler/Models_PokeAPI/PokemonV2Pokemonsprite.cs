namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Pokemonsprite
{
    public int Id { get; set; }

    public int? PokemonId { get; set; }

    public string Sprites { get; set; } = null!;

    public virtual PokemonV2Pokemon? Pokemon { get; set; }
}
