namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Pokemontype
{
    public int Id { get; set; }

    public int Slot { get; set; }

    public int? PokemonId { get; set; }

    public int? TypeId { get; set; }

    public virtual PokemonV2Pokemon? Pokemon { get; set; }

    public virtual PokemonV2Type? Type { get; set; }
}
