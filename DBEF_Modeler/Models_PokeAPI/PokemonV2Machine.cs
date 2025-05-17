namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Machine
{
    public int Id { get; set; }

    public int MachineNumber { get; set; }

    public int? GrowthRateId { get; set; }

    public int? MoveId { get; set; }

    public int? VersionGroupId { get; set; }

    public int? ItemId { get; set; }

    public virtual PokemonV2Growthrate? GrowthRate { get; set; }

    public virtual PokemonV2Item? Item { get; set; }

    public virtual PokemonV2Move? Move { get; set; }

    public virtual PokemonV2Versiongroup? VersionGroup { get; set; }
}
