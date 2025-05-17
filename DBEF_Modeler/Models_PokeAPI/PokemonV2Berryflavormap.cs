namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Berryflavormap
{
    public int Id { get; set; }

    public int Potency { get; set; }

    public int? BerryId { get; set; }

    public int? BerryFlavorId { get; set; }

    public virtual PokemonV2Berry? Berry { get; set; }

    public virtual PokemonV2Berryflavor? BerryFlavor { get; set; }
}
