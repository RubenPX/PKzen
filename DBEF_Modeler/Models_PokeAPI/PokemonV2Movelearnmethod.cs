namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Movelearnmethod
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<PokemonV2Movelearnmethoddescription> PokemonV2Movelearnmethoddescriptions { get; set; } = new List<PokemonV2Movelearnmethoddescription>();

    public virtual ICollection<PokemonV2Movelearnmethodname> PokemonV2Movelearnmethodnames { get; set; } = new List<PokemonV2Movelearnmethodname>();

    public virtual ICollection<PokemonV2Pokemonmove> PokemonV2Pokemonmoves { get; set; } = new List<PokemonV2Pokemonmove>();

    public virtual ICollection<PokemonV2Versiongroupmovelearnmethod> PokemonV2Versiongroupmovelearnmethods { get; set; } = new List<PokemonV2Versiongroupmovelearnmethod>();
}
