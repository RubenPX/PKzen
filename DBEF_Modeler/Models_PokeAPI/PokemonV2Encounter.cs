namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Encounter
{
    public int Id { get; set; }

    public int MinLevel { get; set; }

    public int MaxLevel { get; set; }

    public int? LocationAreaId { get; set; }

    public int? PokemonId { get; set; }

    public int? VersionId { get; set; }

    public int? EncounterSlotId { get; set; }

    public virtual PokemonV2Encounterslot? EncounterSlot { get; set; }

    public virtual PokemonV2Locationarea? LocationArea { get; set; }

    public virtual PokemonV2Pokemon? Pokemon { get; set; }

    public virtual ICollection<PokemonV2Encounterconditionvaluemap> PokemonV2Encounterconditionvaluemaps { get; set; } = new List<PokemonV2Encounterconditionvaluemap>();

    public virtual PokemonV2Version? Version { get; set; }
}
