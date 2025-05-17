namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Pokemonformname
{
    public int Id { get; set; }

    public string PokemonName { get; set; } = null!;

    public int? LanguageId { get; set; }

    public int? PokemonFormId { get; set; }

    public string Name { get; set; } = null!;

    public virtual PokemonV2Language? Language { get; set; }

    public virtual PokemonV2Pokemonform? PokemonForm { get; set; }
}
