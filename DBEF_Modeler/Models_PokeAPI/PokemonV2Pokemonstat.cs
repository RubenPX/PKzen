namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Pokemonstat
{
    public int Id { get; set; }

    public int BaseStat { get; set; }

    public int Effort { get; set; }

    public int? PokemonId { get; set; }

    public int? StatId { get; set; }

    public virtual PokemonV2Pokemon? Pokemon { get; set; }

    public virtual PokemonV2Stat? Stat { get; set; }
}
