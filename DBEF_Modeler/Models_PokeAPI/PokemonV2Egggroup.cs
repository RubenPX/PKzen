namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Egggroup
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<PokemonV2Egggroupname> PokemonV2Egggroupnames { get; set; } = new List<PokemonV2Egggroupname>();

    public virtual ICollection<PokemonV2Pokemonegggroup> PokemonV2Pokemonegggroups { get; set; } = new List<PokemonV2Pokemonegggroup>();
}
