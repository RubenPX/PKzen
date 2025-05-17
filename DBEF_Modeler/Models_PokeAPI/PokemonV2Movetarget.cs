namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Movetarget
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<PokemonV2Move> PokemonV2Moves { get; set; } = new List<PokemonV2Move>();

    public virtual ICollection<PokemonV2Movetargetdescription> PokemonV2Movetargetdescriptions { get; set; } = new List<PokemonV2Movetargetdescription>();

    public virtual ICollection<PokemonV2Movetargetname> PokemonV2Movetargetnames { get; set; } = new List<PokemonV2Movetargetname>();
}
