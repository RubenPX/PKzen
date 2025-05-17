namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Egggroupname
{
    public int Id { get; set; }

    public int? EggGroupId { get; set; }

    public int? LanguageId { get; set; }

    public string Name { get; set; } = null!;

    public virtual PokemonV2Egggroup? EggGroup { get; set; }

    public virtual PokemonV2Language? Language { get; set; }
}
