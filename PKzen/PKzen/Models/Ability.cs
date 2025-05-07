using PKzen.DataAccess;

namespace PKzen.Models;

public class Ability {
    private readonly PokemonAbilityDal _pokemonAbilityDal = new();

    private IEnumerable<PokemonAbility>? _pokemonAbilities;

    public Ability() { }

    public Ability(int id, string name, string? description, bool isHidden, bool isSelected) {
        Id = id;
        Name = name;
        Description = description;
        IsHidden = isHidden;
        IsSelected = isSelected;
    }

    public int Id { get; }
    public string Name { get; }
    public string? Description { get; }
    public bool IsHidden { get; }
    public bool IsSelected { get; }

    public IEnumerable<PokemonAbility> PokemonAbilities => _pokemonAbilities ??= _pokemonAbilityDal.GetByAbilityId(Id);
    public IEnumerable<Pokemon> Pokemons => PokemonAbilities.Select(pa => pa.Pokemon);
}
