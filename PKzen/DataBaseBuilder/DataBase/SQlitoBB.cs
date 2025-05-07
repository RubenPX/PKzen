using DataBaseBuilder.DataBuilder;
using Microsoft.EntityFrameworkCore;

namespace DataBaseBuilder.DataBase;

public class SQlitoBB : DbContext {
    private const string databaseFileName = "PokemonDatabase.db";
    private SQlitoBB() { }

    public static PokemonDbContext BuildConnection(bool createIfNotExists = false, bool generateSampleData = false) {
        var options = new DbContextOptionsBuilder<PokemonDbContext>()
            .UseSqlite($"Data Source={databaseFileName}")
            .Options;

        var context = new PokemonDbContext(options);
        if (createIfNotExists) {
            Console.WriteLine("Creando el esquema de la base de datos...");
            context.Database.EnsureCreated();
            Console.WriteLine("Esquema creado con éxito.");
        }

        if (generateSampleData) PokemonSampleGenerator.GenerateSampleData(context);

        return context;
    }
}
