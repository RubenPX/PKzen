namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Pokemoncolor
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<PokemonV2Pokemoncolorname> PokemonV2Pokemoncolornames { get; set; } = new List<PokemonV2Pokemoncolorname>();

    public virtual ICollection<PokemonV2Pokemonspecy> PokemonV2Pokemonspecies { get; set; } = new List<PokemonV2Pokemonspecy>();
}
