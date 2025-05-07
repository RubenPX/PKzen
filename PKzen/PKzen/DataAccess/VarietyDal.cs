using PKzen.Models;

namespace PKzen.DataAccess;

public class VarietyDal : RepositoryBase<Variety> {
    private const string TABLE = "Variety";

    public override Variety GetById(int id) {
        return QuerySingle<Variety>($"SELECT * FROM {TABLE} WHERE Id = @Id", new { Id = id })!;
    }

    public override IEnumerable<Variety> GetAll() {
        return Query<Variety>($"SELECT * FROM {TABLE}");
    }

    public IEnumerable<Variety> GetBySpeciesId(int speciesId) {
        return Query<Variety>($"SELECT * FROM {TABLE} WHERE SpeciesId = @SpeciesId", new { SpeciesId = speciesId });
    }
}
