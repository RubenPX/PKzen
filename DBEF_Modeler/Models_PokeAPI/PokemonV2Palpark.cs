namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Palpark
{
    public int Id { get; set; }

    public int Rate { get; set; }

    public int? PalParkAreaId { get; set; }

    public int? PokemonSpeciesId { get; set; }

    public int? BaseScore { get; set; }

    public virtual PokemonV2Palparkarea? PalParkArea { get; set; }

    public virtual PokemonV2Pokemonspecy? PokemonSpecies { get; set; }
}
