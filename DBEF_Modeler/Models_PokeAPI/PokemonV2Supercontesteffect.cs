namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Supercontesteffect
{
    public int Id { get; set; }

    public int Appeal { get; set; }

    public virtual ICollection<PokemonV2Move> PokemonV2Moves { get; set; } = new List<PokemonV2Move>();

    public virtual ICollection<PokemonV2Supercontesteffectflavortext> PokemonV2Supercontesteffectflavortexts { get; set; } = new List<PokemonV2Supercontesteffectflavortext>();
}
