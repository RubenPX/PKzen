// See https://aka.ms/new-console-template for more information

using DBEF_Modeler.Models_PokeAPI;

// NOTA: Esto ha sido autogenerado por Scaffolding y aplicando técnicas de ingeniería inversa
// https://learn.microsoft.com/es-es/ef/core/managing-schemas/scaffolding/?tabs=dotnet-core-cli

// Command: dotnet ef dbcontext scaffold "Data Source=K:\Temporalis\PKzen\DBEF_Modeler\PokeAPIDB.sqlite3" Microsoft.EntityFrameworkCore.Sqlite

// Aqui se esta usando la base de datos original de PokeAPI (Base de datos actualizada a 17/05/2025 14:30)

using var context = new PokeApidbContext();

foreach (var pokemon in context.PokemonV2Pokemons.OrderBy(pkmn => pkmn.Id)) {
    Console.WriteLine($"Pokemon({pokemon.Id}): " + pokemon.Name);
}

Console.WriteLine($"Hay {context.PokemonV2Pokemons.Count()} pokemons");
