using RWorld.classes;
using System.Diagnostics.Contracts;
using System.Net.Http.Headers;
using System.Transactions;

RpgClasse rpg = new RpgClasse();
rpg.nome = "";
rpg.idade = 0;
rpg.narmadura = "";
rpg.nIA = "";

Console.Clear();

Console.WriteLine($".-------------------------------.");
Console.WriteLine($"|Bem-Vindo ao Melhor game de RPG|");
Console.WriteLine($"|            RWorld             |");
Console.WriteLine($".-------------------------------.\r\n");
Console.WriteLine($"Digite o nome do seu Personagem:");
rpg.nome = Console.ReadLine();
Console.WriteLine($"Digite a Idade dele:");
rpg.idade = int.Parse(Console.ReadLine());

Console.WriteLine($"!Digite o nome da armadura que ele ultiliza:");
rpg.narmadura = Console.ReadLine();

Console.WriteLine($"!Digite o nome da Ia que ira ajuda-lo:");
rpg.nIA = Console.ReadLine();

Console.Clear();
Console.Clear();

Console.WriteLine($"Seu nome é: {rpg.nome}");
Console.WriteLine($"Sua idade é: {rpg.idade}");
Console.WriteLine($"Esta usando a armadura: {rpg.narmadura}");
Console.WriteLine($"IA que ira te acompanhar é: {rpg.nIA}\r\n"); 

rpg.Atacar();
rpg.Defender();
rpg.RestaurandoArmadura();
