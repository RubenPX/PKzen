namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Region
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual PokemonV2Generation? PokemonV2Generation { get; set; }

    public virtual ICollection<PokemonV2Location> PokemonV2Locations { get; set; } = new List<PokemonV2Location>();

    public virtual ICollection<PokemonV2Pokedex> PokemonV2Pokedices { get; set; } = new List<PokemonV2Pokedex>();

    public virtual ICollection<PokemonV2Regionname> PokemonV2Regionnames { get; set; } = new List<PokemonV2Regionname>();

    public virtual ICollection<PokemonV2Versiongroupregion> PokemonV2Versiongroupregions { get; set; } = new List<PokemonV2Versiongroupregion>();
}
