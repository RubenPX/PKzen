using PKzen.Models;

namespace PKzen.DataAccess;

public class CriesDal : RepositoryBase<Cries> {
    private const string TABLE = "Cries";

    public override Cries GetById(int id) {
        return QuerySingle<Cries>($"SELECT * FROM {TABLE} WHERE Id = @Id", new { Id = id })!;
    }

    public override IEnumerable<Cries> GetAll() {
        return Query<Cries>($"SELECT * FROM {TABLE}");
    }

    public IEnumerable<Cries> GetBySpeciesId(int speciesId) {
        return Query<Cries>($"SELECT * FROM {TABLE} WHERE SpeciesId = @SpeciesId", new { SpeciesId = speciesId });
    }
}
