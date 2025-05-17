namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Contestcombo
{
    public int Id { get; set; }

    public int? FirstMoveId { get; set; }

    public int? SecondMoveId { get; set; }

    public virtual PokemonV2Move? FirstMove { get; set; }

    public virtual PokemonV2Move? SecondMove { get; set; }
}
