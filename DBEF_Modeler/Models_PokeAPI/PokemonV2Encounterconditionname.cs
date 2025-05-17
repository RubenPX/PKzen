namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Encounterconditionname
{
    public int Id { get; set; }

    public int? EncounterConditionId { get; set; }

    public int? LanguageId { get; set; }

    public string Name { get; set; } = null!;

    public virtual PokemonV2Encountercondition? EncounterCondition { get; set; }

    public virtual PokemonV2Language? Language { get; set; }
}
