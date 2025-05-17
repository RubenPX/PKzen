namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Encounterconditionvalue
{
    public int Id { get; set; }

    public bool IsDefault { get; set; }

    public int? EncounterConditionId { get; set; }

    public string Name { get; set; } = null!;

    public virtual PokemonV2Encountercondition? EncounterCondition { get; set; }

    public virtual ICollection<PokemonV2Encounterconditionvaluemap> PokemonV2Encounterconditionvaluemaps { get; set; } = new List<PokemonV2Encounterconditionvaluemap>();

    public virtual ICollection<PokemonV2Encounterconditionvaluename> PokemonV2Encounterconditionvaluenames { get; set; } = new List<PokemonV2Encounterconditionvaluename>();
}
