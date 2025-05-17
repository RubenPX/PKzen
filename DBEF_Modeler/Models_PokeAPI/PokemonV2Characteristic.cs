namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Characteristic
{
    public int Id { get; set; }

    public int GeneMod5 { get; set; }

    public int? StatId { get; set; }

    public virtual ICollection<PokemonV2Characteristicdescription> PokemonV2Characteristicdescriptions { get; set; } = new List<PokemonV2Characteristicdescription>();

    public virtual PokemonV2Stat? Stat { get; set; }
}
