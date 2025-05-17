namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Itemsprite
{
    public int Id { get; set; }

    public int? ItemId { get; set; }

    public string Sprites { get; set; } = null!;

    public virtual PokemonV2Item? Item { get; set; }
}
