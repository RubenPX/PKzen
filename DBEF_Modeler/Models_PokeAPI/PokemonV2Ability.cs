namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Ability
{
    public int Id { get; set; }

    public bool IsMainSeries { get; set; }

    public int? GenerationId { get; set; }

    public string Name { get; set; } = null!;

    public virtual PokemonV2Generation? Generation { get; set; }

    public virtual ICollection<PokemonV2Abilitychange> PokemonV2Abilitychanges { get; set; } = new List<PokemonV2Abilitychange>();

    public virtual ICollection<PokemonV2Abilityeffecttext> PokemonV2Abilityeffecttexts { get; set; } = new List<PokemonV2Abilityeffecttext>();

    public virtual ICollection<PokemonV2Abilityflavortext> PokemonV2Abilityflavortexts { get; set; } = new List<PokemonV2Abilityflavortext>();

    public virtual ICollection<PokemonV2Abilityname> PokemonV2Abilitynames { get; set; } = new List<PokemonV2Abilityname>();

    public virtual ICollection<PokemonV2Pokemonability> PokemonV2Pokemonabilities { get; set; } = new List<PokemonV2Pokemonability>();

    public virtual ICollection<PokemonV2Pokemonabilitypast> PokemonV2Pokemonabilitypasts { get; set; } = new List<PokemonV2Pokemonabilitypast>();
}
