namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Stat
{
    public int Id { get; set; }

    public bool IsBattleOnly { get; set; }

    public int GameIndex { get; set; }

    public int? MoveDamageClassId { get; set; }

    public string Name { get; set; } = null!;

    public virtual PokemonV2Movedamageclass? MoveDamageClass { get; set; }

    public virtual ICollection<PokemonV2Characteristic> PokemonV2Characteristics { get; set; } = new List<PokemonV2Characteristic>();

    public virtual ICollection<PokemonV2Movemetastatchange> PokemonV2Movemetastatchanges { get; set; } = new List<PokemonV2Movemetastatchange>();

    public virtual ICollection<PokemonV2Nature> PokemonV2NatureDecreasedStats { get; set; } = new List<PokemonV2Nature>();

    public virtual ICollection<PokemonV2Nature> PokemonV2NatureIncreasedStats { get; set; } = new List<PokemonV2Nature>();

    public virtual ICollection<PokemonV2Pokemonstat> PokemonV2Pokemonstats { get; set; } = new List<PokemonV2Pokemonstat>();

    public virtual ICollection<PokemonV2Statname> PokemonV2Statnames { get; set; } = new List<PokemonV2Statname>();
}
