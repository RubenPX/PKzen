namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Pokemonegggroup
{
    public int Id { get; set; }

    public int? EggGroupId { get; set; }

    public int? PokemonSpeciesId { get; set; }

    public virtual PokemonV2Egggroup? EggGroup { get; set; }

    public virtual PokemonV2Pokemonspecy? PokemonSpecies { get; set; }
}
