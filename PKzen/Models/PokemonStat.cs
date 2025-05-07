using PKzen.DataAccess;

namespace PKzen.Models;

public class PokemonStat {
    private readonly PokemonDal _pokemonDal = new();
    private readonly StatDal _statDal = new();

    private Pokemon? _pokemon;
    private Stat? _stat;

    public PokemonStat() { }

    public PokemonStat(int id, int baseStat, int effort, int pokemonId, int statId) {
        Id = id;
        BaseStat = baseStat;
        Effort = effort;
        PokemonId = pokemonId;
        StatId = statId;
    }

    public int Id { get; }
    public int BaseStat { get; }
    public int Effort { get; }
    public int PokemonId { get; }
    public int StatId { get; }

    public Pokemon Pokemon => _pokemon ??= _pokemonDal.GetById(PokemonId);
    public Stat Stat => _stat ??= _statDal.GetById(StatId);
}
