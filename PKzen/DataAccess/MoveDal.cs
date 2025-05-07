using PKzen.Models;

namespace PKzen.DataAccess;

public class MoveDal : RepositoryBase<Move> {
    private const string TABLE = "Move";

    public override Move GetById(int id) {
        return QuerySingle<Move>($"SELECT * FROM {TABLE} WHERE Id = @Id", new { Id = id })!;
    }

    public override IEnumerable<Move> GetAll() {
        return Query<Move>($"SELECT * FROM {TABLE}");
    }

    public IEnumerable<Move> GetByPokemonId(int pokemonId) {
        return Query<Move>($"SELECT * FROM {TABLE} WHERE PokemonId = @PokemonId", new { PokemonId = pokemonId });
    }
}
