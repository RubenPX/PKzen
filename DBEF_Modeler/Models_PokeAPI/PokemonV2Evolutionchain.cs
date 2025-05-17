namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Evolutionchain
{
    public int Id { get; set; }

    public int? BabyTriggerItemId { get; set; }

    public virtual PokemonV2Item? BabyTriggerItem { get; set; }

    public virtual ICollection<PokemonV2Pokemonspecy> PokemonV2Pokemonspecies { get; set; } = new List<PokemonV2Pokemonspecy>();
}
