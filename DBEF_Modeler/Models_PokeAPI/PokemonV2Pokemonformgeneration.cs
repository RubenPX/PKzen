namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Pokemonformgeneration
{
    public int Id { get; set; }

    public int GameIndex { get; set; }

    public int? GenerationId { get; set; }

    public int? PokemonFormId { get; set; }

    public virtual PokemonV2Generation? Generation { get; set; }

    public virtual PokemonV2Pokemonform? PokemonForm { get; set; }
}
