namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Itemattributename
{
    public int Id { get; set; }

    public int? ItemAttributeId { get; set; }

    public int? LanguageId { get; set; }

    public string Name { get; set; } = null!;

    public virtual PokemonV2Itemattribute? ItemAttribute { get; set; }

    public virtual PokemonV2Language? Language { get; set; }
}
