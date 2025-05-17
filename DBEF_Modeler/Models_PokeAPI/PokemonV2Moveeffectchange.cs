namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Moveeffectchange
{
    public int Id { get; set; }

    public int? MoveEffectId { get; set; }

    public int? VersionGroupId { get; set; }

    public virtual PokemonV2Moveeffect? MoveEffect { get; set; }

    public virtual ICollection<PokemonV2Moveeffectchangeeffecttext> PokemonV2Moveeffectchangeeffecttexts { get; set; } = new List<PokemonV2Moveeffectchangeeffecttext>();

    public virtual PokemonV2Versiongroup? VersionGroup { get; set; }
}
