namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Versiongroupmovelearnmethod
{
    public int Id { get; set; }

    public int? MoveLearnMethodId { get; set; }

    public int? VersionGroupId { get; set; }

    public virtual PokemonV2Movelearnmethod? MoveLearnMethod { get; set; }

    public virtual PokemonV2Versiongroup? VersionGroup { get; set; }
}
