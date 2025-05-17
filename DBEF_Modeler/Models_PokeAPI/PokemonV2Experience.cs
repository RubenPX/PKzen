namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Experience
{
    public int Id { get; set; }

    public int Level { get; set; }

    public int Experience { get; set; }

    public int? GrowthRateId { get; set; }

    public virtual PokemonV2Growthrate? GrowthRate { get; set; }
}
