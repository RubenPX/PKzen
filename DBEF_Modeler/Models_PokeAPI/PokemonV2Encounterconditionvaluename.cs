namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Encounterconditionvaluename
{
    public int Id { get; set; }

    public int? EncounterConditionValueId { get; set; }

    public int? LanguageId { get; set; }

    public string Name { get; set; } = null!;

    public virtual PokemonV2Encounterconditionvalue? EncounterConditionValue { get; set; }

    public virtual PokemonV2Language? Language { get; set; }
}
