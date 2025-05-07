using PKzen.DataAccess;

namespace PKzen.Models;

public class StatChange {
    private readonly MoveDal _moveDal = new();
    private readonly StatDal _statDal = new();
    private IEnumerable<StatChange>? _null;

    private Stat? _stat;

    public StatChange() { }

    public StatChange(int id, int change, int statId, int moveId) {
        Id = id;
        Change = change;
        StatId = statId;
        MoveId = moveId;
    }

    public int Id { get; }
    public int Change { get; }
    public int StatId { get; }
    public int MoveId { get; }

    public Stat Stat => _stat ??= _statDal.GetById(StatId);
    public Move Move => _moveDal.GetById(MoveId);
}
