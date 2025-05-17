namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Pokemonhabitat
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<PokemonV2Pokemonhabitatname> PokemonV2Pokemonhabitatnames { get; set; } = new List<PokemonV2Pokemonhabitatname>();

    public virtual ICollection<PokemonV2Pokemonspecy> PokemonV2Pokemonspecies { get; set; } = new List<PokemonV2Pokemonspecy>();
}
