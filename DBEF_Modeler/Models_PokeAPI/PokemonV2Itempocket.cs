namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Itempocket
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<PokemonV2Itemcategory> PokemonV2Itemcategories { get; set; } = new List<PokemonV2Itemcategory>();

    public virtual ICollection<PokemonV2Itempocketname> PokemonV2Itempocketnames { get; set; } = new List<PokemonV2Itempocketname>();
}
