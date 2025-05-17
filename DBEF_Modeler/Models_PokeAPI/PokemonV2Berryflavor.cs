namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Berryflavor
{
    public int Id { get; set; }

    public int? ContestTypeId { get; set; }

    public string Name { get; set; } = null!;

    public virtual PokemonV2Contesttype? ContestType { get; set; }

    public virtual ICollection<PokemonV2Berryflavormap> PokemonV2Berryflavormaps { get; set; } = new List<PokemonV2Berryflavormap>();

    public virtual ICollection<PokemonV2Berryflavorname> PokemonV2Berryflavornames { get; set; } = new List<PokemonV2Berryflavorname>();

    public virtual ICollection<PokemonV2Nature> PokemonV2NatureHatesFlavors { get; set; } = new List<PokemonV2Nature>();

    public virtual ICollection<PokemonV2Nature> PokemonV2NatureLikesFlavors { get; set; } = new List<PokemonV2Nature>();
}
