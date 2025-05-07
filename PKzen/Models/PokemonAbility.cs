using PKzen.DataAccess;

namespace PKzen.Models;

public class PokemonAbility {
    private readonly AbilityDal _abilityDal = new();
    private readonly PokemonDal _pokemonDal = new();
    private Ability? _ability;

    private Pokemon? _pokemon;

    public PokemonAbility() { }

    public PokemonAbility(int pokemonId, int abilityId) {
        PokemonId = pokemonId;
        AbilityId = abilityId;
    }

    public int PokemonId { get; }
    public int AbilityId { get; }

    public Pokemon Pokemon => _pokemon ??= _pokemonDal.GetById(PokemonId);
    public Ability Ability => _ability ??= _abilityDal.GetById(AbilityId);
}
