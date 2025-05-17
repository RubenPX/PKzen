namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Naturebattlestylepreference
{
    public int Id { get; set; }

    public int LowHpPreference { get; set; }

    public int HighHpPreference { get; set; }

    public int? NatureId { get; set; }

    public int? MoveBattleStyleId { get; set; }

    public virtual PokemonV2Movebattlestyle? MoveBattleStyle { get; set; }

    public virtual PokemonV2Nature? Nature { get; set; }
}
