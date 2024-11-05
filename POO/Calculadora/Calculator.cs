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

calc.Somar(0f);

// Console.WriteLine($"Soma:{calc.Somar(0f)}");
// Console.WriteLine($"Subtrair:{calc.Subtrair(0f)}");
// Console.WriteLine($"Multiplicar:{calc.Multiplicar(0f)}");
// Console.WriteLine($"Dividir:{calc.Dividir(0f)}");
