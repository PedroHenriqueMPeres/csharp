int[] numeros = new int[6]; //array vazio
int par = 0, impar = 0;

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Digite o {i + 1}º número");
    int numeroDigitado = int.Parse(Console.ReadLine()!);
    numeros[i] = numeroDigitado;//guarda o número no array

    if (numeroDigitado % 2 == 0)
    {
        par++;
    }
    else
    {
        impar++;
    }
}

Console.WriteLine($"{par} número(s) par(es): ");

for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] %2 == 0)
{
    Console.WriteLine($"Par");
}
}

Console.WriteLine($"{impar} número(s) impar(es):");

for (int i = 0; i < numeros.Length; i++)
if (numeros[i] %2 == 0){
{
    Console.WriteLine($"Impar");
}
}