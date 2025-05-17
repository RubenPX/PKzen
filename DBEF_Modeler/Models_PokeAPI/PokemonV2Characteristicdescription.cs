namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Characteristicdescription
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public int? CharacteristicId { get; set; }

    public int? LanguageId { get; set; }

    public virtual PokemonV2Characteristic? Characteristic { get; set; }

    public virtual PokemonV2Language? Language { get; set; }
}
