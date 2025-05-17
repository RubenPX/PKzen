namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Pokemonability
{
    public int Id { get; set; }

    public bool IsHidden { get; set; }

    public int Slot { get; set; }

    public int? AbilityId { get; set; }

    public int? PokemonId { get; set; }

    public virtual PokemonV2Ability? Ability { get; set; }

    public virtual PokemonV2Pokemon? Pokemon { get; set; }
}
