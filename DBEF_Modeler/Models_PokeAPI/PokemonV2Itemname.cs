namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Itemname
{
    public int Id { get; set; }

    public int? ItemId { get; set; }

    public int? LanguageId { get; set; }

    public string Name { get; set; } = null!;

    public virtual PokemonV2Item? Item { get; set; }

    public virtual PokemonV2Language? Language { get; set; }
}
