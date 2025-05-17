namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Version
{
    public int Id { get; set; }

    public int? VersionGroupId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<PokemonV2Encounter> PokemonV2Encounters { get; set; } = new List<PokemonV2Encounter>();

    public virtual ICollection<PokemonV2Locationareaencounterrate> PokemonV2Locationareaencounterrates { get; set; } = new List<PokemonV2Locationareaencounterrate>();

    public virtual ICollection<PokemonV2Pokemongameindex> PokemonV2Pokemongameindices { get; set; } = new List<PokemonV2Pokemongameindex>();

    public virtual ICollection<PokemonV2Pokemonitem> PokemonV2Pokemonitems { get; set; } = new List<PokemonV2Pokemonitem>();

    public virtual ICollection<PokemonV2Pokemonspeciesflavortext> PokemonV2Pokemonspeciesflavortexts { get; set; } = new List<PokemonV2Pokemonspeciesflavortext>();

    public virtual ICollection<PokemonV2Versionname> PokemonV2Versionnames { get; set; } = new List<PokemonV2Versionname>();

    public virtual PokemonV2Versiongroup? VersionGroup { get; set; }
}
