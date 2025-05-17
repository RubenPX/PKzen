namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Movemetaailment
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<PokemonV2Movemetum> PokemonV2Movemeta { get; set; } = new List<PokemonV2Movemetum>();

    public virtual ICollection<PokemonV2Movemetaailmentname> PokemonV2Movemetaailmentnames { get; set; } = new List<PokemonV2Movemetaailmentname>();
}
