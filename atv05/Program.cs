float maçãs;

float precounitario;

Console.WriteLine ($"Quantas maçãs você ira comprar:");
int nmaçãs = int.Parse(Console.ReadLine()!);

if (nmaçãs < 12)
{
    precounitario = 0.30f;
}

else{
    precounitario = 0.25f;
}

float total = precounitario * nmaçãs;

Console.WriteLine ($"Total a pagar: {total}");