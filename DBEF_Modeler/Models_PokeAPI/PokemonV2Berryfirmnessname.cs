namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Berryfirmnessname
{
    public int Id { get; set; }

    public int? BerryFirmnessId { get; set; }

    public int? LanguageId { get; set; }

    public string Name { get; set; } = null!;

    public virtual PokemonV2Berryfirmness? BerryFirmness { get; set; }

    public virtual PokemonV2Language? Language { get; set; }
}
