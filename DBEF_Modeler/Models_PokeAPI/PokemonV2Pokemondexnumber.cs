namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Pokemondexnumber
{
    public int Id { get; set; }

    public int PokedexNumber { get; set; }

    public int? PokedexId { get; set; }

    public int? PokemonSpeciesId { get; set; }

    public virtual PokemonV2Pokedex? Pokedex { get; set; }

    public virtual PokemonV2Pokemonspecy? PokemonSpecies { get; set; }
}
