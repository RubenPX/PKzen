// See https://aka.ms/new-console-template for more information

using DataBaseBuilder.DataBase;

var database = SQlitoBB.BuildConnection(true, true);
foreach (var pokemon in database.Pokemon.Select(itm => itm.Name)) Console.WriteLine($"Pokemon: {pokemon}");
