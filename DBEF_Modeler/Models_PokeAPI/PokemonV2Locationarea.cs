namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Locationarea
{
    public int Id { get; set; }

    public int GameIndex { get; set; }

    public int? LocationId { get; set; }

    public string Name { get; set; } = null!;

    public virtual PokemonV2Location? Location { get; set; }

    public virtual ICollection<PokemonV2Encounter> PokemonV2Encounters { get; set; } = new List<PokemonV2Encounter>();

    public virtual ICollection<PokemonV2Locationareaencounterrate> PokemonV2Locationareaencounterrates { get; set; } = new List<PokemonV2Locationareaencounterrate>();

    public virtual ICollection<PokemonV2Locationareaname> PokemonV2Locationareanames { get; set; } = new List<PokemonV2Locationareaname>();
}
