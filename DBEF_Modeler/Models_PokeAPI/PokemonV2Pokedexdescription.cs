namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Pokedexdescription
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public int? LanguageId { get; set; }

    public int? PokedexId { get; set; }

    public virtual PokemonV2Language? Language { get; set; }

    public virtual PokemonV2Pokedex? Pokedex { get; set; }
}
