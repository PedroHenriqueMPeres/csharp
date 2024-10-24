int qnthomem = 0;
int qntmulher = 0;


Console.WriteLine("Qual seu sexo:");
int qntdenrevistados = int.Parse(Console.ReadLine()!);


for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("Qual seu sexo:");
    string sexo = Console.ReadLine();
    if (sexo == "f")
    {
        qntmulher++;
    }else{qnthomem++;}
}

Console.WriteLine($"Quantidade de Mulheres: {qntmulher}");
Console.WriteLine($"Quantidade de Homems: {qnthomem}");