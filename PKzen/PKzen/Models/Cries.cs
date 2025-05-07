using PKzen.DataAccess;

namespace PKzen.Models;

public class Cries {
    private readonly SpeciesDal _speciesDal = new();

    private Species? _species;

    public Cries() { }

    public Cries(int id, string? latest, string? legacy, int speciesId) {
        Id = id;
        Latest = latest;
        Legacy = legacy;
        SpeciesId = speciesId;
    }

    public int Id { get; }
    public string? Latest { get; }
    public string? Legacy { get; }
    public int SpeciesId { get; }

    public Species Species => _species ??= _speciesDal.GetById(SpeciesId);
}
