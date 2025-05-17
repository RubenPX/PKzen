namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Itempocketname
{
    public int Id { get; set; }

    public int? ItemPocketId { get; set; }

    public int? LanguageId { get; set; }

    public string Name { get; set; } = null!;

    public virtual PokemonV2Itempocket? ItemPocket { get; set; }

    public virtual PokemonV2Language? Language { get; set; }
}
