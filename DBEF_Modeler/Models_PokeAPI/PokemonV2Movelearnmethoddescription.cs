namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Movelearnmethoddescription
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public int? LanguageId { get; set; }

    public int? MoveLearnMethodId { get; set; }

    public virtual PokemonV2Language? Language { get; set; }

    public virtual PokemonV2Movelearnmethod? MoveLearnMethod { get; set; }
}
