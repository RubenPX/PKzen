namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Pokemonshape
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<PokemonV2Pokemonshapename> PokemonV2Pokemonshapenames { get; set; } = new List<PokemonV2Pokemonshapename>();

    public virtual ICollection<PokemonV2Pokemonspecy> PokemonV2Pokemonspecies { get; set; } = new List<PokemonV2Pokemonspecy>();
}
