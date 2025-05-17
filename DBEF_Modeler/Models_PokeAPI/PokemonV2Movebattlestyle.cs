namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Movebattlestyle
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<PokemonV2Movebattlestylename> PokemonV2Movebattlestylenames { get; set; } = new List<PokemonV2Movebattlestylename>();

    public virtual ICollection<PokemonV2Naturebattlestylepreference> PokemonV2Naturebattlestylepreferences { get; set; } = new List<PokemonV2Naturebattlestylepreference>();
}
