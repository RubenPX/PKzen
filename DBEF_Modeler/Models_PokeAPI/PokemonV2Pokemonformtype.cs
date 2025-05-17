namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Pokemonformtype
{
    public int Id { get; set; }

    public int Slot { get; set; }

    public int? PokemonFormId { get; set; }

    public int? TypeId { get; set; }

    public virtual PokemonV2Pokemonform? PokemonForm { get; set; }

    public virtual PokemonV2Type? Type { get; set; }
}
