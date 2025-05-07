namespace PKzen.Models;

public class EggGroup {
    public EggGroup() { }

    public EggGroup(int id, string name) {
        Id = id;
        Name = name;
    }

    public int Id { get; }
    public string Name { get; }
}
