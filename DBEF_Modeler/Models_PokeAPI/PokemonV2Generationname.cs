namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Generationname
{
    public int Id { get; set; }

    public int? GenerationId { get; set; }

    public int? LanguageId { get; set; }

    public string Name { get; set; } = null!;

    public virtual PokemonV2Generation? Generation { get; set; }

    public virtual PokemonV2Language? Language { get; set; }
}
