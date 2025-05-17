namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Abilitychange
{
    public int Id { get; set; }

    public int? AbilityId { get; set; }

    public int? VersionGroupId { get; set; }

    public virtual PokemonV2Ability? Ability { get; set; }

    public virtual ICollection<PokemonV2Abilitychangeeffecttext> PokemonV2Abilitychangeeffecttexts { get; set; } = new List<PokemonV2Abilitychangeeffecttext>();

    public virtual PokemonV2Versiongroup? VersionGroup { get; set; }
}
