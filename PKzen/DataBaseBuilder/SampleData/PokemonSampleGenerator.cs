using DataBaseBuilder.DataBuilder;
using Microsoft.EntityFrameworkCore;

namespace DataBaseBuilder;

public class PokemonSampleGenerator {
    private static readonly string sqlScriptFileName = "K:\\Temporalis\\RiderProjects\\PKzen\\DataBaseBuilder\\SampleData\\SampleDB.sql";

    public static void GenerateSampleData(PokemonDbContext context) {
        if (context.Pokemon.Any()) {
            Console.WriteLine("La base de datos ya contiene datos. No se insertarán duplicados.");
            return;
        }

        Console.WriteLine("La base de datos no existe. Creándola...");


        if (File.Exists(sqlScriptFileName)) {
            Console.WriteLine($"Ejecutando el script SQL: {sqlScriptFileName}...");

            var sqlScript = File.ReadAllText(sqlScriptFileName);
            context.Database.ExecuteSqlRaw(sqlScript);

            Console.WriteLine("Script SQL ejecutado con éxito.");
        } else {
            Console.WriteLine($"El archivo de script SQL {sqlScriptFileName} no fue encontrado.");
        }

        Console.WriteLine("¡Conexión y operaciones completadas!");
    }
}
