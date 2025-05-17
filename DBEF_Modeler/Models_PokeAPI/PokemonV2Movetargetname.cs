namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Movetargetname
{
    public int Id { get; set; }

    public int? LanguageId { get; set; }

    public int? MoveTargetId { get; set; }

    public string Name { get; set; } = null!;

    public virtual PokemonV2Language? Language { get; set; }

    public virtual PokemonV2Movetarget? MoveTarget { get; set; }
}
