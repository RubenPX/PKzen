namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Pokeathlonstat
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<PokemonV2Naturepokeathlonstat> PokemonV2Naturepokeathlonstats { get; set; } = new List<PokemonV2Naturepokeathlonstat>();

    public virtual ICollection<PokemonV2Pokeathlonstatname> PokemonV2Pokeathlonstatnames { get; set; } = new List<PokemonV2Pokeathlonstatname>();
}
