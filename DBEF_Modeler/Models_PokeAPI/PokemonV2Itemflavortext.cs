namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Itemflavortext
{
    public int Id { get; set; }

    public string FlavorText { get; set; } = null!;

    public int? ItemId { get; set; }

    public int? LanguageId { get; set; }

    public int? VersionGroupId { get; set; }

    public virtual PokemonV2Item? Item { get; set; }

    public virtual PokemonV2Language? Language { get; set; }

    public virtual PokemonV2Versiongroup? VersionGroup { get; set; }
}
