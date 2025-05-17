namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Itemcategory
{
    public int Id { get; set; }

    public int? ItemPocketId { get; set; }

    public string Name { get; set; } = null!;

    public virtual PokemonV2Itempocket? ItemPocket { get; set; }

    public virtual ICollection<PokemonV2Itemcategoryname> PokemonV2Itemcategorynames { get; set; } = new List<PokemonV2Itemcategoryname>();

    public virtual ICollection<PokemonV2Item> PokemonV2Items { get; set; } = new List<PokemonV2Item>();
}
