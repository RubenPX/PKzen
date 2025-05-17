namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Pokedexname
{
    public int Id { get; set; }

    public int? LanguageId { get; set; }

    public int? PokedexId { get; set; }

    public string Name { get; set; } = null!;

    public virtual PokemonV2Language? Language { get; set; }

    public virtual PokemonV2Pokedex? Pokedex { get; set; }
}
