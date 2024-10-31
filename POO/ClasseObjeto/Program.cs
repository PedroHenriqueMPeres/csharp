using ClasseObjeto.Classes;
using System.Net.Http.Headers;

Animal cachorro = new Animal();

cachorro.nome = "Kleberson";
cachorro.especie = "Shitzu";
cachorro.cor = "Branco";
cachorro.idade = 9;

Animal furão = new Animal();

furão.nome = "Gleide";
furão.especie = "Sable.";
furão.cor = "Branco";
furão.idade = 8;

Console.Clear();

Console.WriteLine($"Nome: {cachorro.nome}");
Console.WriteLine($"Idade do {cachorro.nome}: {cachorro.idade} anos");
Console.WriteLine($"Cor do {cachorro.nome}: {cachorro.cor}");
Console.WriteLine($"Especie do {cachorro.nome}: {cachorro.especie}");

Console.WriteLine($"\r\nNome: {furão.nome}");
Console.WriteLine($"Idade do {furão.nome}: {furão.idade} meses");
Console.WriteLine($"Cor do {furão.nome}: {furão.cor}");
Console.WriteLine($"Especie do {furão.nome}: {furão.especie}");


