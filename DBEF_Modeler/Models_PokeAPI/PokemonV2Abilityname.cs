namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Abilityname
{
    public int Id { get; set; }

    public int? AbilityId { get; set; }

    public int? LanguageId { get; set; }

    public string Name { get; set; } = null!;

    public virtual PokemonV2Ability? Ability { get; set; }

    public virtual PokemonV2Language? Language { get; set; }
}
