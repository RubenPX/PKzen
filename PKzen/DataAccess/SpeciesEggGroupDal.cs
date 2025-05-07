using PKzen.Models;

namespace PKzen.DataAccess;

public class SpeciesEggGroupDal : RepositoryBase<SpeciesEggGroup> {
    private const string TABLE = "SpeciesEggGroup";

    public override SpeciesEggGroup GetById(int id) {
        throw new NotImplementedException();
    }

    public override IEnumerable<SpeciesEggGroup> GetAll() {
        return Query<SpeciesEggGroup>($"SELECT * FROM {TABLE}");
    }

    public IEnumerable<SpeciesEggGroup> GetBySpeciesId(int speciesId) {
        return Query<SpeciesEggGroup>($"SELECT * FROM {TABLE} WHERE SpeciesId = @SpeciesId", new { SpeciesId = speciesId });
    }

    public IEnumerable<SpeciesEggGroup> GetByEggGroupId(int eggGroupId) {
        return Query<SpeciesEggGroup>($"SELECT * FROM {TABLE} WHERE EggGroupId = @EggGroupId", new { EggGroupId = eggGroupId });
    }
}
