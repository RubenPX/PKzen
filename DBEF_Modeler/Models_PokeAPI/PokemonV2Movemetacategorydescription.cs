namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Movemetacategorydescription
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public int? LanguageId { get; set; }

    public int? MoveMetaCategoryId { get; set; }

    public virtual PokemonV2Language? Language { get; set; }

    public virtual PokemonV2Movemetacategory? MoveMetaCategory { get; set; }
}
