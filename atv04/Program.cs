
int senha=1234;
Console.WriteLine ($"Digite a senha");
int numerodigi = int.Parse(Console.ReadLine()!);

 if(numerodigi != senha){
    Console.WriteLine ($"Acesso Negado");
}
else{
     Console.WriteLine ($"Acesso Permitido");
 }