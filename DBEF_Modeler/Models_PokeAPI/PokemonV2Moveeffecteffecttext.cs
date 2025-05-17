namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Moveeffecteffecttext
{
    public int Id { get; set; }

    public string Effect { get; set; } = null!;

    public string ShortEffect { get; set; } = null!;

    public int? LanguageId { get; set; }

    public int? MoveEffectId { get; set; }

    public virtual PokemonV2Language? Language { get; set; }

    public virtual PokemonV2Moveeffect? MoveEffect { get; set; }
}
