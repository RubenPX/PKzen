namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Locationname
{
    public int Id { get; set; }

    public int? LanguageId { get; set; }

    public int? LocationId { get; set; }

    public string Name { get; set; } = null!;

    public virtual PokemonV2Language? Language { get; set; }

    public virtual PokemonV2Location? Location { get; set; }
}
