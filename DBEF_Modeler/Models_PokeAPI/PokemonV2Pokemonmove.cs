namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Pokemonmove
{
    public int Id { get; set; }

    public int? Order { get; set; }

    public int Level { get; set; }

    public int? MoveId { get; set; }

    public int? PokemonId { get; set; }

    public int? VersionGroupId { get; set; }

    public int? MoveLearnMethodId { get; set; }

    public int? Mastery { get; set; }

    public virtual PokemonV2Move? Move { get; set; }

    public virtual PokemonV2Movelearnmethod? MoveLearnMethod { get; set; }

    public virtual PokemonV2Pokemon? Pokemon { get; set; }

    public virtual PokemonV2Versiongroup? VersionGroup { get; set; }
}
