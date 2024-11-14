using Calculadora.classes;
using System.Diagnostics.Contracts;
using System.Net.Http.Headers;
using System.Transactions;

Calcular calc = new Calcular();
calc.numero1 = 2;
calc.numero2 = 2;

Console.Clear();

Console.WriteLine($"Bem-Vindo a Calculadora das 4 Op");
Console.WriteLine($"Digite um número:");
calc.numero1 = float.Parse(Console.ReadLine());
Console.WriteLine($"Digite outro número:");
calc.numero2 = float.Parse(Console.ReadLine());

Console.Clear();

calc.Somar(0f);
calc.Subtrair(0f);
calc.Multiplicar(0f);
calc.Dividir(0f);
