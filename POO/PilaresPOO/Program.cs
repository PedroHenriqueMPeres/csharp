using PilaresPOO.Classes.Aprendizagem;

// Professor sam = new Professor(1234135);
// sam.nome = "Samanta";
// sam.idade = 22;

// Aluno Pedro = new Aluno();
// Pedro.nome = "Pedro";
// Pedro.idade = 17;
// Pedro.cpf = "545.712.798.25";
// Pedro.peso = 67f;
// Pedro.altura = 1.70f;
// Pedro.matricula = "Feita";
// Pedro.média = 8.5f;
// Pedro.curso = "D.I";

// Console.Clear();

// Console.WriteLine(@$"Nome: {Pedro.nome}
// Idade: {Pedro.idade}
// Cpf: {Pedro.cpf}
// Peso: {Pedro.peso}
// Altura: {Pedro.altura}
// Matricula: {Pedro.matricula}
// Média: {Pedro.média}
// Curso: {Pedro.curso}
// Nome Professor: {sam.nome}
// Idade do Professor: {sam.idade}");

Carros Porsche = new Carros();
Porsche.modelo = "GT3 RS";
Porsche.marca = "Porsche";
Porsche.qntportas = 2;
Porsche.potencia = "525cv";

Console.WriteLine(@$"Modelo: {Porsche.modelo}
Marca:{Porsche.marca}
Portas:{Porsche.qntportas}
Potencia:{Porsche.potencia}
");
Porsche.Ligar();
Porsche.Desligar();
Porsche.Buzinar();
Console.WriteLine($"\r\n");

Moto BMW = new Moto();
BMW.modelo = "S1000 RR";
BMW.marca = "BMW";
BMW.qntportas = 0;
BMW.potencia = "210cv";

Console.WriteLine(@$"Modelo: {BMW.modelo}
Marca:{BMW.marca}
Portas:{BMW.qntportas}
Potencia:{BMW.potencia}
");
BMW.Ligar();
BMW.Desligar();
BMW.Buzinar();

Console.WriteLine($"\r\n");


Aviao Boing = new Aviao();
Boing.modelo = "Boeing 777";
Boing.marca = "Boing";
Boing.qntportas = 2;
Boing.potencia = "175.000 cv";

Console.WriteLine(@$"Modelo: {Boing.modelo}
Marca:{Boing.marca}
Portas:{Boing.qntportas}
Potencia:{Boing.potencia}
");
Boing.Ligar();
Boing.Desligar();
Boing.Buzinar();

Console.WriteLine($"\r\n");


