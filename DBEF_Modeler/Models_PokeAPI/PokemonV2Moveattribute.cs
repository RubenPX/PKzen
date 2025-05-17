namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Moveattribute
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<PokemonV2Moveattributedescription> PokemonV2Moveattributedescriptions { get; set; } = new List<PokemonV2Moveattributedescription>();

    public virtual ICollection<PokemonV2Moveattributemap> PokemonV2Moveattributemaps { get; set; } = new List<PokemonV2Moveattributemap>();

    public virtual ICollection<PokemonV2Moveattributename> PokemonV2Moveattributenames { get; set; } = new List<PokemonV2Moveattributename>();
}
