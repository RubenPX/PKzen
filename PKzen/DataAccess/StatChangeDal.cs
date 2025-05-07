using PKzen.Models;

namespace PKzen.DataAccess;

public class StatChangeDal : RepositoryBase<StatChange> {
    private const string TABLE = "StatChange";

    public override StatChange GetById(int id) {
        return QuerySingle<StatChange>($"SELECT * FROM {TABLE} WHERE Id = @Id", new { Id = id })!;
    }

    public override IEnumerable<StatChange> GetAll() {
        return Query<StatChange>($"SELECT * FROM {TABLE}");
    }

    public IEnumerable<StatChange> GetByMoveId(int moveId) {
        return Query<StatChange>($"SELECT * FROM {TABLE} WHERE MoveId = @MoveId", new { MoveId = moveId });
    }
}
