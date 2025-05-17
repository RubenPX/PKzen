namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Itemeffecttext
{
    public int Id { get; set; }

    public string Effect { get; set; } = null!;

    public string ShortEffect { get; set; } = null!;

    public int? ItemId { get; set; }

    public int? LanguageId { get; set; }

    public virtual PokemonV2Item? Item { get; set; }

    public virtual PokemonV2Language? Language { get; set; }
}
