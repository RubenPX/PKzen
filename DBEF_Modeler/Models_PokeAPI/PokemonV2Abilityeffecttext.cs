namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Abilityeffecttext
{
    public int Id { get; set; }

    public string Effect { get; set; } = null!;

    public string ShortEffect { get; set; } = null!;

    public int? AbilityId { get; set; }

    public int? LanguageId { get; set; }

    public virtual PokemonV2Ability? Ability { get; set; }

    public virtual PokemonV2Language? Language { get; set; }
}
