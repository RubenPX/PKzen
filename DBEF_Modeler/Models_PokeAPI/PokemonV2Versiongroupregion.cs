namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Versiongroupregion
{
    public int Id { get; set; }

    public int? VersionGroupId { get; set; }

    public int? RegionId { get; set; }

    public virtual PokemonV2Region? Region { get; set; }

    public virtual PokemonV2Versiongroup? VersionGroup { get; set; }
}
