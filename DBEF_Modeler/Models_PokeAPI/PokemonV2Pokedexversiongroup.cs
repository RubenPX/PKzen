namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Pokedexversiongroup
{
    public int Id { get; set; }

    public int? PokedexId { get; set; }

    public int? VersionGroupId { get; set; }

    public virtual PokemonV2Pokedex? Pokedex { get; set; }

    public virtual PokemonV2Versiongroup? VersionGroup { get; set; }
}
