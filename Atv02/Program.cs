

Console.WriteLine ($"Quantos gols time A fez");
int golsTimeA = int.Parse(Console.ReadLine()!);

Console.WriteLine ($"Quantos gols time B fez ");
int golsTimeb = int.Parse(Console.ReadLine()!);

Console.Clear();

if( golsTimeA > golsTimeb){
    Console.WriteLine ($"Vitoria time A");

}else if(golsTimeA < golsTimeb){
    Console.WriteLine ($"Vitoria time B");
}
else{
    Console.WriteLine ($"Empate");
}
