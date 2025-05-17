namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Moveattributemap
{
    public int Id { get; set; }

    public int? MoveId { get; set; }

    public int? MoveAttributeId { get; set; }

    public virtual PokemonV2Move? Move { get; set; }

    public virtual PokemonV2Moveattribute? MoveAttribute { get; set; }
}
