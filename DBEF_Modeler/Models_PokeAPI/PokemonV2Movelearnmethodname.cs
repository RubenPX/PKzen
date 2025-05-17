namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Movelearnmethodname
{
    public int Id { get; set; }

    public int? LanguageId { get; set; }

    public int? MoveLearnMethodId { get; set; }

    public string Name { get; set; } = null!;

    public virtual PokemonV2Language? Language { get; set; }

    public virtual PokemonV2Movelearnmethod? MoveLearnMethod { get; set; }
}
