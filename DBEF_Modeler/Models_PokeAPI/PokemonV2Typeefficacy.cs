namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Typeefficacy
{
    public int Id { get; set; }

    public int DamageFactor { get; set; }

    public int? DamageTypeId { get; set; }

    public int? TargetTypeId { get; set; }

    public virtual PokemonV2Type? DamageType { get; set; }

    public virtual PokemonV2Type? TargetType { get; set; }
}
