namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Moveeffect
{
    public int Id { get; set; }

    public virtual ICollection<PokemonV2Movechange> PokemonV2Movechanges { get; set; } = new List<PokemonV2Movechange>();

    public virtual ICollection<PokemonV2Moveeffectchange> PokemonV2Moveeffectchanges { get; set; } = new List<PokemonV2Moveeffectchange>();

    public virtual ICollection<PokemonV2Moveeffecteffecttext> PokemonV2Moveeffecteffecttexts { get; set; } = new List<PokemonV2Moveeffecteffecttext>();

    public virtual ICollection<PokemonV2Move> PokemonV2Moves { get; set; } = new List<PokemonV2Move>();
}
