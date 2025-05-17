namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Movemetastatchange
{
    public int Id { get; set; }

    public int Change { get; set; }

    public int? MoveId { get; set; }

    public int? StatId { get; set; }

    public virtual PokemonV2Move? Move { get; set; }

    public virtual PokemonV2Stat? Stat { get; set; }
}
