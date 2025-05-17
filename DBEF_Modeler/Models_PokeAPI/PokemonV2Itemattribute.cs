namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Itemattribute
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<PokemonV2Itemattributedescription> PokemonV2Itemattributedescriptions { get; set; } = new List<PokemonV2Itemattributedescription>();

    public virtual ICollection<PokemonV2Itemattributemap> PokemonV2Itemattributemaps { get; set; } = new List<PokemonV2Itemattributemap>();

    public virtual ICollection<PokemonV2Itemattributename> PokemonV2Itemattributenames { get; set; } = new List<PokemonV2Itemattributename>();
}
