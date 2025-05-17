namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Berryfirmness
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<PokemonV2Berry> PokemonV2Berries { get; set; } = new List<PokemonV2Berry>();

    public virtual ICollection<PokemonV2Berryfirmnessname> PokemonV2Berryfirmnessnames { get; set; } = new List<PokemonV2Berryfirmnessname>();
}
