namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Contesteffecteffecttext
{
    public int Id { get; set; }

    public string Effect { get; set; } = null!;

    public int? ContestEffectId { get; set; }

    public int? LanguageId { get; set; }

    public virtual PokemonV2Contesteffect? ContestEffect { get; set; }

    public virtual PokemonV2Language? Language { get; set; }
}
