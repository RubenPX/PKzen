namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Berry
{
    public int Id { get; set; }

    public int NaturalGiftPower { get; set; }

    public int Size { get; set; }

    public int MaxHarvest { get; set; }

    public int GrowthTime { get; set; }

    public int SoilDryness { get; set; }

    public int Smoothness { get; set; }

    public int? BerryFirmnessId { get; set; }

    public int? ItemId { get; set; }

    public int? NaturalGiftTypeId { get; set; }

    public string Name { get; set; } = null!;

    public virtual PokemonV2Berryfirmness? BerryFirmness { get; set; }

    public virtual PokemonV2Item? Item { get; set; }

    public virtual PokemonV2Type? NaturalGiftType { get; set; }

    public virtual ICollection<PokemonV2Berryflavormap> PokemonV2Berryflavormaps { get; set; } = new List<PokemonV2Berryflavormap>();
}
