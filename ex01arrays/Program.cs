﻿// string carro0;
// string carro1;
// string carro2;

string[] carros = new string [3];

for (int i = 0; i < carros.Length; i++)
{
    
Console.WriteLine($"Digite o nome do carro a ser cadastrado:");
carros[i] = Console.ReadLine()!;

}

Console.WriteLine($"O carro cadastrado é {carros[0]}, {carros[1]}, {carros[2]}");