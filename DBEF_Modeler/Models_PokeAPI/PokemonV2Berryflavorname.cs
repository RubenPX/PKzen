namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Berryflavorname
{
    public int Id { get; set; }

    public int? BerryFlavorId { get; set; }

    public int? LanguageId { get; set; }

    public string Name { get; set; } = null!;

    public virtual PokemonV2Berryflavor? BerryFlavor { get; set; }

    public virtual PokemonV2Language? Language { get; set; }
}
