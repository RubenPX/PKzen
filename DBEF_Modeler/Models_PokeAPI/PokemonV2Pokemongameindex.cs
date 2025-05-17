namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Pokemongameindex
{
    public int Id { get; set; }

    public int GameIndex { get; set; }

    public int? PokemonId { get; set; }

    public int? VersionId { get; set; }

    public virtual PokemonV2Pokemon? Pokemon { get; set; }

    public virtual PokemonV2Version? Version { get; set; }
}
