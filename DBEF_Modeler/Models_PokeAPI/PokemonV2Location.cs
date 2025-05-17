namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Location
{
    public int Id { get; set; }

    public int? RegionId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<PokemonV2Locationarea> PokemonV2Locationareas { get; set; } = new List<PokemonV2Locationarea>();

    public virtual ICollection<PokemonV2Locationgameindex> PokemonV2Locationgameindices { get; set; } = new List<PokemonV2Locationgameindex>();

    public virtual ICollection<PokemonV2Locationname> PokemonV2Locationnames { get; set; } = new List<PokemonV2Locationname>();

    public virtual ICollection<PokemonV2Pokemonevolution> PokemonV2Pokemonevolutions { get; set; } = new List<PokemonV2Pokemonevolution>();

    public virtual PokemonV2Region? Region { get; set; }
}
