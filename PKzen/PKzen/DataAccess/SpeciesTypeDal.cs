using PKzen.Models;

namespace PKzen.DataAccess;

public class SpeciesTypeDal : RepositoryBase<SpeciesType> {
    private const string TABLE = "SpeciesType";

    public override SpeciesType GetById(int id) {
        return QuerySingle<SpeciesType>($"SELECT * FROM {TABLE} WHERE Id = @Id", new { Id = id })!;
    }

    public override IEnumerable<SpeciesType> GetAll() {
        return Query<SpeciesType>($"SELECT * FROM {TABLE}");
    }

    public IEnumerable<SpeciesType> GetBySpeciesId(int speciesId) {
        return Query<SpeciesType>($"SELECT * FROM {TABLE} WHERE SpeciesId = @SpeciesId", new { SpeciesId = speciesId });
    }

    public IEnumerable<SpeciesType> GetByTypeId(int typeId) {
        return Query<SpeciesType>($"SELECT * FROM {TABLE} WHERE TypeId = @TypeId", new { TypeId = typeId });
    }
}
