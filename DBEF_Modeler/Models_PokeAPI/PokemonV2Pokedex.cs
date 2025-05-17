namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Pokedex
{
    public int Id { get; set; }

    public bool IsMainSeries { get; set; }

    public int? RegionId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<PokemonV2Pokedexdescription> PokemonV2Pokedexdescriptions { get; set; } = new List<PokemonV2Pokedexdescription>();

    public virtual ICollection<PokemonV2Pokedexname> PokemonV2Pokedexnames { get; set; } = new List<PokemonV2Pokedexname>();

    public virtual ICollection<PokemonV2Pokedexversiongroup> PokemonV2Pokedexversiongroups { get; set; } = new List<PokemonV2Pokedexversiongroup>();

    public virtual ICollection<PokemonV2Pokemondexnumber> PokemonV2Pokemondexnumbers { get; set; } = new List<PokemonV2Pokemondexnumber>();

    public virtual PokemonV2Region? Region { get; set; }
}
