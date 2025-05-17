namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Supercontesteffectflavortext
{
    public int Id { get; set; }

    public string FlavorText { get; set; } = null!;

    public int? LanguageId { get; set; }

    public int? SuperContestEffectId { get; set; }

    public virtual PokemonV2Language? Language { get; set; }

    public virtual PokemonV2Supercontesteffect? SuperContestEffect { get; set; }
}
