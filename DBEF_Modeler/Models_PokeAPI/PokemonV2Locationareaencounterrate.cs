namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Locationareaencounterrate
{
    public int Id { get; set; }

    public int Rate { get; set; }

    public int? LocationAreaId { get; set; }

    public int? VersionId { get; set; }

    public int? EncounterMethodId { get; set; }

    public virtual PokemonV2Encountermethod? EncounterMethod { get; set; }

    public virtual PokemonV2Locationarea? LocationArea { get; set; }

    public virtual PokemonV2Version? Version { get; set; }
}
