namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Moveattributedescription
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public int? LanguageId { get; set; }

    public int? MoveAttributeId { get; set; }

    public virtual PokemonV2Language? Language { get; set; }

    public virtual PokemonV2Moveattribute? MoveAttribute { get; set; }
}
