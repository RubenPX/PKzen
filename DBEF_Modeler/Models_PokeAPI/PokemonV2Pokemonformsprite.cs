namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Pokemonformsprite
{
    public int Id { get; set; }

    public int? PokemonFormId { get; set; }

    public string Sprites { get; set; } = null!;

    public virtual PokemonV2Pokemonform? PokemonForm { get; set; }
}
