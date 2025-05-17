namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Moveeffectchangeeffecttext
{
    public int Id { get; set; }

    public string Effect { get; set; } = null!;

    public int? LanguageId { get; set; }

    public int? MoveEffectChangeId { get; set; }

    public virtual PokemonV2Language? Language { get; set; }

    public virtual PokemonV2Moveeffectchange? MoveEffectChange { get; set; }
}
