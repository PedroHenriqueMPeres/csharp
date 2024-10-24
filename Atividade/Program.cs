Console.WriteLine ($"Quanto você recebe: ");
float salario = float.Parse(Console.ReadLine()!);

Console.WriteLine ($"Quanto você foi gasto ");
float valorgasto = float.Parse(Console.ReadLine()!);


Console.Clear();
Console.WriteLine ($"Informações:\r\n {salario}\r\n {valorgasto}\r\n ");
if(salario >= valorgasto){
    Console.WriteLine ($"Dentro do orçamento");

}else
{
    Console.WriteLine ($"Orçamento estourado");
}

