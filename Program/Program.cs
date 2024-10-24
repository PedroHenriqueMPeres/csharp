int qnthomem = 0;
int qntmulher = 0;
int gstesporte = 0;
int ngstesporte = 0;
Console.WriteLine("Quantas pessoas tem na sua mesa:");
int qntdenrevistados = int.Parse(Console.ReadLine()!);


for (int i = 1; i <= qntdenrevistados; i++)
{
    Console.WriteLine("Qual seu sexo:");
    string sexo = Console.ReadLine();
    if (sexo == "f")
    {
        qntmulher++;
    }
    else { qnthomem++; }

    Console.WriteLine("Você gosta de esporte:(s/n)");
    string qntesporte = Console.ReadLine();
    if (qntesporte == "s")
    {
        gstesporte++;
    }
    else
    {
        ngstesporte++;
    }
}

Console.WriteLine($"Quantidade de Entrevistados: {qntmulher + qnthomem}");
Console.WriteLine($"Quantidade de Mulheres: {qntmulher}");
Console.WriteLine($"Quantidade de Homems: {qnthomem}");
Console.WriteLine($"Pessoas que gostam de Esporte: {gstesporte}");
Console.WriteLine($"Pessoas que não gostam de Esporte: {ngstesporte}");