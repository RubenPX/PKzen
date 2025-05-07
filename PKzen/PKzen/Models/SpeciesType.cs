using PKzen.DataAccess;

namespace PKzen.Models;

public class SpeciesType {
    private readonly TypeDal _typeDal = new();

    private Type? _type;

    public SpeciesType() { }

    public SpeciesType(int id, int slot, int speciesId, int typeId) {
        Id = id;
        Slot = slot;
        SpeciesId = speciesId;
        TypeId = typeId;
    }

    public int Id { get; }
    public int Slot { get; }
    public int SpeciesId { get; }
    public int TypeId { get; }

    public Type Type => _type ??= _typeDal.GetById(TypeId);
}
