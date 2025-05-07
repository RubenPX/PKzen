using PKzen.DataAccess;

namespace PKzen.Models;

public class DamageRelation {
    private readonly TypeDal _typeDal = new();

    private Type? _type;

    public DamageRelation() { }

    public DamageRelation(int speciesId, int typeId, double relationType) {
        SpeciesId = speciesId;
        TypeId = typeId;
        RelationType = relationType;
    }

    public int SpeciesId { get; }
    public int TypeId { get; }
    public double RelationType { get; }

    public Type Type => _type ??= _typeDal.GetById(TypeId);
}
