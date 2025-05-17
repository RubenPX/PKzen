namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Pokemonspeciesname
{
    public int Id { get; set; }

    public string Genus { get; set; } = null!;

    public int? LanguageId { get; set; }

    public int? PokemonSpeciesId { get; set; }

    public string Name { get; set; } = null!;

    public virtual PokemonV2Language? Language { get; set; }

    public virtual PokemonV2Pokemonspecy? PokemonSpecies { get; set; }
}
