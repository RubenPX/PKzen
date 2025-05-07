using PKzen.Models;

namespace PKzen.DataAccess;

public class DamageRelationDal : RepositoryBase<DamageRelation> {
    private const string TABLE = "DamageRelation";

    public override DamageRelation GetById(int id) {
        throw new NotImplementedException();
    }

    public override IEnumerable<DamageRelation> GetAll() {
        return Query<DamageRelation>($"SELECT * FROM {TABLE}");
    }

    public IEnumerable<DamageRelation> GetBySpeciesId(int speciesId) {
        return Query<DamageRelation>($"SELECT * FROM {TABLE} WHERE SpeciesId = @SpeciesId", new { SpeciesId = speciesId });
    }
}
