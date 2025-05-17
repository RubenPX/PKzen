namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Movedamageclass
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<PokemonV2Movedamageclassdescription> PokemonV2Movedamageclassdescriptions { get; set; } = new List<PokemonV2Movedamageclassdescription>();

    public virtual ICollection<PokemonV2Movedamageclassname> PokemonV2Movedamageclassnames { get; set; } = new List<PokemonV2Movedamageclassname>();

    public virtual ICollection<PokemonV2Move> PokemonV2Moves { get; set; } = new List<PokemonV2Move>();

    public virtual ICollection<PokemonV2Stat> PokemonV2Stats { get; set; } = new List<PokemonV2Stat>();

    public virtual ICollection<PokemonV2Type> PokemonV2Types { get; set; } = new List<PokemonV2Type>();
}
