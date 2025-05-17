namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Palparkarea
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<PokemonV2Palparkareaname> PokemonV2Palparkareanames { get; set; } = new List<PokemonV2Palparkareaname>();

    public virtual ICollection<PokemonV2Palpark> PokemonV2Palparks { get; set; } = new List<PokemonV2Palpark>();
}
