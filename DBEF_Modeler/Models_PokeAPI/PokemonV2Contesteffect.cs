namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Contesteffect
{
    public int Id { get; set; }

    public int Appeal { get; set; }

    public int Jam { get; set; }

    public virtual ICollection<PokemonV2Contesteffecteffecttext> PokemonV2Contesteffecteffecttexts { get; set; } = new List<PokemonV2Contesteffecteffecttext>();

    public virtual ICollection<PokemonV2Contesteffectflavortext> PokemonV2Contesteffectflavortexts { get; set; } = new List<PokemonV2Contesteffectflavortext>();

    public virtual ICollection<PokemonV2Move> PokemonV2Moves { get; set; } = new List<PokemonV2Move>();
}
