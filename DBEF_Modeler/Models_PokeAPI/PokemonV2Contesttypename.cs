namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Contesttypename
{
    public int Id { get; set; }

    public string Flavor { get; set; } = null!;

    public string Color { get; set; } = null!;

    public int? ContestTypeId { get; set; }

    public int? LanguageId { get; set; }

    public string Name { get; set; } = null!;

    public virtual PokemonV2Contesttype? ContestType { get; set; }

    public virtual PokemonV2Language? Language { get; set; }
}
