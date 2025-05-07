using PKzen.Models;

namespace PKzen.DataAccess;

public class AbilityDal : RepositoryBase<Ability> {
    private const string TABLE = "Ability";

    public override Ability GetById(int id) {
        return QuerySingle<Ability>(
            $"SELECT Id, Name, Description, IsHidden, IsSelected FROM {TABLE} WHERE Id = @Id",
            new { Id = id })!;
    }

    public override IEnumerable<Ability> GetAll() {
        return Query<Ability>($"SELECT Id, Name, Description, IsHidden, IsSelected FROM {TABLE}");
    }

    public IEnumerable<Ability> GetByPokemonId(int pokemonId) {
        return Query<Ability>(
            "SELECT a.* FROM Ability a " +
            "JOIN PokemonAbility pa ON pa.AbilityId = a.Id " +
            "WHERE pa.PokemonId = @Pid",
            new { Pid = pokemonId });
    }

    public IEnumerable<Ability> GetSelected() {
        return Query<Ability>(
            $"SELECT Id, Name, Description, IsHidden, IsSelected FROM {TABLE} WHERE IsSelected = 1");
    }
}
