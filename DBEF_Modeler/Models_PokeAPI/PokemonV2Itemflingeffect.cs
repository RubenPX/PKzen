namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Itemflingeffect
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<PokemonV2Itemflingeffecteffecttext> PokemonV2Itemflingeffecteffecttexts { get; set; } = new List<PokemonV2Itemflingeffecteffecttext>();

    public virtual ICollection<PokemonV2Item> PokemonV2Items { get; set; } = new List<PokemonV2Item>();
}
