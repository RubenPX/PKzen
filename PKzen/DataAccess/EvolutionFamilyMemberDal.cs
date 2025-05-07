using PKzen.Models;

namespace PKzen.DataAccess;

public class EvolutionFamilyMemberDal : RepositoryBase<EvolutionFamilyMember> {
    private const string TABLE = "EvolutionFamilyMember";

    public override EvolutionFamilyMember GetById(int id) {
        return QuerySingle<EvolutionFamilyMember>($"SELECT * FROM {TABLE} WHERE Id = @Id", new { Id = id })!;
    }

    public override IEnumerable<EvolutionFamilyMember> GetAll() {
        return Query<EvolutionFamilyMember>($"SELECT * FROM {TABLE}");
    }

    public IEnumerable<EvolutionFamilyMember> GetByChainId(int chainId) {
        return Query<EvolutionFamilyMember>($"SELECT * FROM {TABLE} WHERE EvolutionChainId = @ChainId", new { ChainId = chainId });
    }
}
