namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Typesprite
{
    public int Id { get; set; }

    public string Sprites { get; set; } = null!;

    public int? TypeId { get; set; }

    public virtual PokemonV2Type? Type { get; set; }
}
