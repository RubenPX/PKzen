namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Growthrate
{
    public int Id { get; set; }

    public string Formula { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual ICollection<PokemonV2Experience> PokemonV2Experiences { get; set; } = new List<PokemonV2Experience>();

    public virtual ICollection<PokemonV2Growthratedescription> PokemonV2Growthratedescriptions { get; set; } = new List<PokemonV2Growthratedescription>();

    public virtual ICollection<PokemonV2Machine> PokemonV2Machines { get; set; } = new List<PokemonV2Machine>();

    public virtual ICollection<PokemonV2Pokemonspecy> PokemonV2Pokemonspecies { get; set; } = new List<PokemonV2Pokemonspecy>();
}
