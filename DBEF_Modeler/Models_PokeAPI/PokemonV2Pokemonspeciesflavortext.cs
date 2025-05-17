namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Pokemonspeciesflavortext
{
    public int Id { get; set; }

    public string FlavorText { get; set; } = null!;

    public int? LanguageId { get; set; }

    public int? PokemonSpeciesId { get; set; }

    public int? VersionId { get; set; }

    public virtual PokemonV2Language? Language { get; set; }

    public virtual PokemonV2Pokemonspecy? PokemonSpecies { get; set; }

    public virtual PokemonV2Version? Version { get; set; }
}
