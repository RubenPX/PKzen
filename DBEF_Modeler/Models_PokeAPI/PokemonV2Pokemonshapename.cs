namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Pokemonshapename
{
    public int Id { get; set; }

    public string AwesomeName { get; set; } = null!;

    public int? LanguageId { get; set; }

    public int? PokemonShapeId { get; set; }

    public string Name { get; set; } = null!;

    public virtual PokemonV2Language? Language { get; set; }

    public virtual PokemonV2Pokemonshape? PokemonShape { get; set; }
}
