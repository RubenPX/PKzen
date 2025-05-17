namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Itemflingeffecteffecttext
{
    public int Id { get; set; }

    public int? ItemFlingEffectId { get; set; }

    public int? LanguageId { get; set; }

    public string Effect { get; set; } = null!;

    public virtual PokemonV2Itemflingeffect? ItemFlingEffect { get; set; }

    public virtual PokemonV2Language? Language { get; set; }
}
