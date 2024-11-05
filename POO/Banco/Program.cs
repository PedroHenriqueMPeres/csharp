using Banco.Classes;
using System.Diagnostics.Contracts;
using System.Net.Http.Headers;
using System.Transactions;

ContaCorrente ContaAlbertin = new ContaCorrente();
ContaAlbertin.NumeroConta = 40028922;
ContaAlbertin.Titular = "Albertin";
ContaAlbertin.saldo = 0f;
ContaAlbertin.deposito = 0f;

ContaCorrente calculototal = new ContaCorrente();

Console.Clear();

Console.WriteLine($"Bem-Vindo ao BancoDoPaís");
Console.WriteLine($"Olá {ContaAlbertin.Titular}");
Console.WriteLine($"Seu saldo é de:{ContaAlbertin.saldo}");

Console.WriteLine($"Quando quer depositar: ");
ContaAlbertin.saldo = float.Parse(Console.ReadLine());

Console.Clear();
Console.WriteLine($"Está é a conta:{ContaAlbertin.NumeroConta}");
Console.WriteLine($"Titular:{ContaAlbertin.Titular}");
Console.WriteLine($"Saldo da conta:{ContaAlbertin.saldo}");