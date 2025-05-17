namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Itemattributemap
{
    public int Id { get; set; }

    public int? ItemId { get; set; }

    public int? ItemAttributeId { get; set; }

    public virtual PokemonV2Item? Item { get; set; }

    public virtual PokemonV2Itemattribute? ItemAttribute { get; set; }
}
