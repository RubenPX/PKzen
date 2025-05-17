namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Movetargetdescription
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public int? LanguageId { get; set; }

    public int? MoveTargetId { get; set; }

    public virtual PokemonV2Language? Language { get; set; }

    public virtual PokemonV2Movetarget? MoveTarget { get; set; }
}
