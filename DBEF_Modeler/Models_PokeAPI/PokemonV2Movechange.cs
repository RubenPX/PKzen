namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Movechange
{
    public int Id { get; set; }

    public int? Power { get; set; }

    public int? Accuracy { get; set; }

    public int? MoveEffectChance { get; set; }

    public int? MoveId { get; set; }

    public int? MoveEffectId { get; set; }

    public int? TypeId { get; set; }

    public int? VersionGroupId { get; set; }

    public int? Pp { get; set; }

    public virtual PokemonV2Move? Move { get; set; }

    public virtual PokemonV2Moveeffect? MoveEffect { get; set; }

    public virtual PokemonV2Type? Type { get; set; }

    public virtual PokemonV2Versiongroup? VersionGroup { get; set; }
}
