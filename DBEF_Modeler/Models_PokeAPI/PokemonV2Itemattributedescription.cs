namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Itemattributedescription
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public int? ItemAttributeId { get; set; }

    public int? LanguageId { get; set; }

    public virtual PokemonV2Itemattribute? ItemAttribute { get; set; }

    public virtual PokemonV2Language? Language { get; set; }
}
