namespace DBEF_Modeler.Models_PokeAPI;

public partial class PokemonV2Item
{
    public int Id { get; set; }

    public int? Cost { get; set; }

    public int? FlingPower { get; set; }

    public int? ItemCategoryId { get; set; }

    public int? ItemFlingEffectId { get; set; }

    public string Name { get; set; } = null!;

    public virtual PokemonV2Itemcategory? ItemCategory { get; set; }

    public virtual PokemonV2Itemflingeffect? ItemFlingEffect { get; set; }

    public virtual ICollection<PokemonV2Berry> PokemonV2Berries { get; set; } = new List<PokemonV2Berry>();

    public virtual ICollection<PokemonV2Evolutionchain> PokemonV2Evolutionchains { get; set; } = new List<PokemonV2Evolutionchain>();

    public virtual ICollection<PokemonV2Itemattributemap> PokemonV2Itemattributemaps { get; set; } = new List<PokemonV2Itemattributemap>();

    public virtual ICollection<PokemonV2Itemeffecttext> PokemonV2Itemeffecttexts { get; set; } = new List<PokemonV2Itemeffecttext>();

    public virtual ICollection<PokemonV2Itemflavortext> PokemonV2Itemflavortexts { get; set; } = new List<PokemonV2Itemflavortext>();

    public virtual ICollection<PokemonV2Itemgameindex> PokemonV2Itemgameindices { get; set; } = new List<PokemonV2Itemgameindex>();

    public virtual ICollection<PokemonV2Itemname> PokemonV2Itemnames { get; set; } = new List<PokemonV2Itemname>();

    public virtual ICollection<PokemonV2Itemsprite> PokemonV2Itemsprites { get; set; } = new List<PokemonV2Itemsprite>();

    public virtual ICollection<PokemonV2Machine> PokemonV2Machines { get; set; } = new List<PokemonV2Machine>();

    public virtual ICollection<PokemonV2Pokemonevolution> PokemonV2PokemonevolutionEvolutionItems { get; set; } = new List<PokemonV2Pokemonevolution>();

    public virtual ICollection<PokemonV2Pokemonevolution> PokemonV2PokemonevolutionHeldItems { get; set; } = new List<PokemonV2Pokemonevolution>();

    public virtual ICollection<PokemonV2Pokemonitem> PokemonV2Pokemonitems { get; set; } = new List<PokemonV2Pokemonitem>();
}
