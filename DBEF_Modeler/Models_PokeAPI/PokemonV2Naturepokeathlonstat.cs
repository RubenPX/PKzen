namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Naturepokeathlonstat
{
    public int Id { get; set; }

    public int MaxChange { get; set; }

    public int? NatureId { get; set; }

    public int? PokeathlonStatId { get; set; }

    public virtual PokemonV2Nature? Nature { get; set; }

    public virtual PokemonV2Pokeathlonstat? PokeathlonStat { get; set; }
}
