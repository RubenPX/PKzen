namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Pokemonspecy
{
    public int Id { get; set; }

    public int? Order { get; set; }

    public int? GenderRate { get; set; }

    public int? CaptureRate { get; set; }

    public int? BaseHappiness { get; set; }

    public bool IsBaby { get; set; }

    public int? HatchCounter { get; set; }

    public bool HasGenderDifferences { get; set; }

    public bool FormsSwitchable { get; set; }

    public int? EvolutionChainId { get; set; }

    public int? GenerationId { get; set; }

    public int? GrowthRateId { get; set; }

    public int? PokemonColorId { get; set; }

    public int? PokemonHabitatId { get; set; }

    public int? PokemonShapeId { get; set; }

    public bool IsLegendary { get; set; }

    public bool IsMythical { get; set; }

    public string Name { get; set; } = null!;

    public int? EvolvesFromSpeciesId { get; set; }

    public virtual PokemonV2Evolutionchain? EvolutionChain { get; set; }

    public virtual PokemonV2Pokemonspecy? EvolvesFromSpecies { get; set; }

    public virtual PokemonV2Generation? Generation { get; set; }

    public virtual PokemonV2Growthrate? GrowthRate { get; set; }

    public virtual ICollection<PokemonV2Pokemonspecy> InverseEvolvesFromSpecies { get; set; } = new List<PokemonV2Pokemonspecy>();

    public virtual PokemonV2Pokemoncolor? PokemonColor { get; set; }

    public virtual PokemonV2Pokemonhabitat? PokemonHabitat { get; set; }

    public virtual PokemonV2Pokemonshape? PokemonShape { get; set; }

    public virtual ICollection<PokemonV2Palpark> PokemonV2Palparks { get; set; } = new List<PokemonV2Palpark>();

    public virtual ICollection<PokemonV2Pokemondexnumber> PokemonV2Pokemondexnumbers { get; set; } = new List<PokemonV2Pokemondexnumber>();

    public virtual ICollection<PokemonV2Pokemonegggroup> PokemonV2Pokemonegggroups { get; set; } = new List<PokemonV2Pokemonegggroup>();

    public virtual ICollection<PokemonV2Pokemonevolution> PokemonV2PokemonevolutionEvolvedSpecies { get; set; } = new List<PokemonV2Pokemonevolution>();

    public virtual ICollection<PokemonV2Pokemonevolution> PokemonV2PokemonevolutionPartySpecies { get; set; } = new List<PokemonV2Pokemonevolution>();

    public virtual ICollection<PokemonV2Pokemonevolution> PokemonV2PokemonevolutionTradeSpecies { get; set; } = new List<PokemonV2Pokemonevolution>();

    public virtual ICollection<PokemonV2Pokemon> PokemonV2Pokemons { get; set; } = new List<PokemonV2Pokemon>();

    public virtual ICollection<PokemonV2Pokemonspeciesdescription> PokemonV2Pokemonspeciesdescriptions { get; set; } = new List<PokemonV2Pokemonspeciesdescription>();

    public virtual ICollection<PokemonV2Pokemonspeciesflavortext> PokemonV2Pokemonspeciesflavortexts { get; set; } = new List<PokemonV2Pokemonspeciesflavortext>();

    public virtual ICollection<PokemonV2Pokemonspeciesname> PokemonV2Pokemonspeciesnames { get; set; } = new List<PokemonV2Pokemonspeciesname>();
}
