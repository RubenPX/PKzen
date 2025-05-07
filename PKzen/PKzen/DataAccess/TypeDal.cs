using Type = PKzen.Models.Type;

namespace PKzen.DataAccess;

public class TypeDal : RepositoryBase<Type> {
    private const string TABLE = "Type";

    public override Type GetById(int id) {
        return QuerySingle<Type>($"SELECT Id, Name FROM {TABLE} WHERE Id = @Id", new { Id = id })!;
    }

    public override IEnumerable<Type> GetAll() {
        return Query<Type>($"SELECT Id, Name FROM {TABLE}");
    }
}
