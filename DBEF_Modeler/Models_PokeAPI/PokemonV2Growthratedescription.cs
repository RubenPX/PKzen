namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Growthratedescription
{
    public int Id { get; set; }

    public int? GrowthRateId { get; set; }

    public int? LanguageId { get; set; }

    public string Description { get; set; } = null!;

    public virtual PokemonV2Growthrate? GrowthRate { get; set; }

    public virtual PokemonV2Language? Language { get; set; }
}
