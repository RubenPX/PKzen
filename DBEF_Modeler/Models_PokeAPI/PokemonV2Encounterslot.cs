namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Encounterslot
{
    public int Id { get; set; }

    public int? Slot { get; set; }

    public int Rarity { get; set; }

    public int? EncounterMethodId { get; set; }

    public int? VersionGroupId { get; set; }

    public virtual PokemonV2Encountermethod? EncounterMethod { get; set; }

    public virtual ICollection<PokemonV2Encounter> PokemonV2Encounters { get; set; } = new List<PokemonV2Encounter>();

    public virtual PokemonV2Versiongroup? VersionGroup { get; set; }
}
