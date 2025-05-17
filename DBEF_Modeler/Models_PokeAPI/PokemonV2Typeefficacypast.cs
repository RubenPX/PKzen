namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Typeefficacypast
{
    public int Id { get; set; }

    public int DamageFactor { get; set; }

    public int? DamageTypeId { get; set; }

    public int? GenerationId { get; set; }

    public int? TargetTypeId { get; set; }

    public virtual PokemonV2Type? DamageType { get; set; }

    public virtual PokemonV2Generation? Generation { get; set; }

    public virtual PokemonV2Type? TargetType { get; set; }
}
