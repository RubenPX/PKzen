using PKzen.Models;

namespace PKzen.DataAccess;

public class PokemonStatDal : RepositoryBase<PokemonStat> {
    private const string TABLE = "PokemonStat";

    public override PokemonStat GetById(int id) {
        return QuerySingle<PokemonStat>($"SELECT * FROM {TABLE} WHERE Id = @Id", new { Id = id })!;
    }

    public override IEnumerable<PokemonStat> GetAll() {
        return Query<PokemonStat>($"SELECT * FROM {TABLE}");
    }

    public IEnumerable<PokemonStat> GetByPokemonId(int pokemonId) {
        return Query<PokemonStat>($"SELECT * FROM {TABLE} WHERE PokemonId = @PokemonId", new { PokemonId = pokemonId });
    }
}
