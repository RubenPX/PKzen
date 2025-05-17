namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Encountermethod
{
    public int Id { get; set; }

    public int? Order { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<PokemonV2Encountermethodname> PokemonV2Encountermethodnames { get; set; } = new List<PokemonV2Encountermethodname>();

    public virtual ICollection<PokemonV2Encounterslot> PokemonV2Encounterslots { get; set; } = new List<PokemonV2Encounterslot>();

    public virtual ICollection<PokemonV2Locationareaencounterrate> PokemonV2Locationareaencounterrates { get; set; } = new List<PokemonV2Locationareaencounterrate>();
}
