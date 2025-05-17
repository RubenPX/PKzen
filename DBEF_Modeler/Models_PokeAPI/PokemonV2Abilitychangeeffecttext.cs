namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Abilitychangeeffecttext
{
    public int Id { get; set; }

    public string Effect { get; set; } = null!;

    public int? AbilityChangeId { get; set; }

    public int? LanguageId { get; set; }

    public virtual PokemonV2Abilitychange? AbilityChange { get; set; }

    public virtual PokemonV2Language? Language { get; set; }
}
