namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Encounterconditionvaluemap
{
    public int Id { get; set; }

    public int? EncounterId { get; set; }

    public int? EncounterConditionValueId { get; set; }

    public virtual PokemonV2Encounter? Encounter { get; set; }

    public virtual PokemonV2Encounterconditionvalue? EncounterConditionValue { get; set; }
}
