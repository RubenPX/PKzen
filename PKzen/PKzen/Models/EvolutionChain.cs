using PKzen.DataAccess;

namespace PKzen.Models;

public class EvolutionChain {
    private readonly EvolutionFamilyMemberDal _memberDal = new();
    private readonly SpeciesDal _speciesDal = new();
    private IEnumerable<EvolutionFamilyMember>? _members;

    private Species? _species;

    public EvolutionChain() { }

    public EvolutionChain(int id, string? babyTriggerItem, int speciesId) {
        Id = id;
        BabyTriggerItem = babyTriggerItem;
        SpeciesId = speciesId;
    }

    public int Id { get; }
    public string? BabyTriggerItem { get; }
    public int SpeciesId { get; }

    public Species Species => _species ??= _speciesDal.GetById(SpeciesId);
    public IEnumerable<EvolutionFamilyMember> Members => _members ??= _memberDal.GetByChainId(Id);
}
