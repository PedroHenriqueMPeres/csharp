using AtividadeClasses.Classes;
using System.Net.Http.Headers;

Carro meuCarro = new Carro();
meuCarro.Marca = "Ford";
meuCarro.Modelo = "Focus";
meuCarro.cor = "Preto";
meuCarro.potencia = "550cv";
meuCarro.qntPortas = "2";

Console.Clear();

Console.WriteLine($"Marca do Carro: {meuCarro.Marca}");
Console.WriteLine($"Modelo do Carro:{meuCarro.Modelo}");
Console.WriteLine($"Cor do Carro:{meuCarro.cor}");
Console.WriteLine($"Potencia do Carro:{meuCarro.potencia}");
Console.WriteLine($"Qnt de portas:{meuCarro.qntPortas}");


meuCarro.Acelerar();
meuCarro.Ligar();
meuCarro.Desligar();
meuCarro.Freiar();

