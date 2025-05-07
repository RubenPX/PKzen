using PKzen.DataAccess;

namespace PKzen.Models;

public class Variety {
    private readonly SpeciesDal _speciesDal = new();

    private Species? _species;

    public Variety() { }

    public Variety(int id, bool isDefault, string name, int speciesId) {
        Id = id;
        IsDefault = isDefault;
        Name = name;
        SpeciesId = speciesId;
    }

    public int Id { get; }
    public bool IsDefault { get; }
    public string Name { get; }
    public int SpeciesId { get; }

    public Species Species => _species ??= _speciesDal.GetById(SpeciesId);
}
