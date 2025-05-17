namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Gender
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<PokemonV2Pokemonevolution> PokemonV2Pokemonevolutions { get; set; } = new List<PokemonV2Pokemonevolution>();
}
