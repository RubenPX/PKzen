namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Encountercondition
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<PokemonV2Encounterconditionname> PokemonV2Encounterconditionnames { get; set; } = new List<PokemonV2Encounterconditionname>();

    public virtual ICollection<PokemonV2Encounterconditionvalue> PokemonV2Encounterconditionvalues { get; set; } = new List<PokemonV2Encounterconditionvalue>();
}
