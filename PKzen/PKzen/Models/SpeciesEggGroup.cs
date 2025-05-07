using PKzen.DataAccess;

namespace PKzen.Models;

public class SpeciesEggGroup {
    private readonly EggGroupDal _eggGroupDal = new();

    private EggGroup? _eggGroup;

    public SpeciesEggGroup() { }

    public SpeciesEggGroup(int speciesId, int eggGroupId) {
        SpeciesId = speciesId;
        EggGroupId = eggGroupId;
    }

    public int SpeciesId { get; }
    public int EggGroupId { get; }

    public EggGroup EggGroup => _eggGroup ??= _eggGroupDal.GetById(EggGroupId);
}
