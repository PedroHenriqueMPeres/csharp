
float lado1 =1;
float lado2 =2;
float lado3 =69;

Console.WriteLine ($"Esse triangulo é");
 if(lado1 == lado2 && lado1 == lado3){
    Console.WriteLine ($"Equilatero");
}else if(lado1 != lado2 && lado1 != lado3 && lado2 != lado3){
    Console.WriteLine ($"Escaleno");
}else{
     Console.WriteLine ($"Isósceles");
 }