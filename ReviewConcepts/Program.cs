Console.Clear();
Console.WriteLine($"+-------------------------------+");
Console.WriteLine($"|                               |");
Console.WriteLine($"|        Olá, !Bom-Dia!         |");
Console.WriteLine($"|  Agora irei pedir seus dados  |");
Console.WriteLine($"|                               |");
Console.WriteLine($"+-------------------------------+");



Console.WriteLine($"|   Olá, Digite seu nome:     |\r\n");
string nome = Console.ReadLine();

Console.WriteLine($"|   Olá, Digite seu sobrenome:   |\r\n");
string sobrenome = Console.ReadLine();

Console.Clear();
Console.WriteLine($"Olá, {nome} {sobrenome}\r\n");

Console.WriteLine($"|   Digite sua data de nascimento:   |\r\n");
//   DateOnly dataNascimento = new DateOnly(2008, 2, 22);
DateOnly dataNascimento = DateOnly.Parse(Console.ReadLine());
        DateOnly dataAtual = DateOnly.FromDateTime(DateTime.Now);
  
        Console.WriteLine("Data de Nascimento: " + dataNascimento);
        Console.WriteLine("Data Atual: " + dataAtual);
  
        int idade = dataAtual.Year - dataNascimento.Year;
        if (dataAtual < dataNascimento.AddYears(idade))
        {
            idade--;
        }

        Console.WriteLine("Idade: " + idade);

Console.WriteLine($"|   Olá, Digite seu email:   |\r\n");
string email = Console.ReadLine();

Console.WriteLine($"|   Olá, Digite seu Telefone:   |\r\n");
UInt128 telefone = UInt128.Parse(Console.ReadLine()!);

Console.WriteLine($"|   Olá, Digite seu CPF:   |\r\n");
UInt128 cpf = UInt128.Parse(Console.ReadLine()!);

Console.WriteLine($"|   Olá, Digite seu endereço:   |\r\n");
string endereco = Console.ReadLine();

Console.WriteLine($"|   Olá, Digite qual o seu EstadoCivil:   |\r\n");
string EstadoCivil = Console.ReadLine();
Console.WriteLine($"+_________________________________+");

Console.Clear();

Console.WriteLine($"Informações do cliente:\r\n {nome} {sobrenome}\r\n{dataNascimento} \r\n{email} \r\n{telefone} \r\n{cpf} \r\n{endereco} \r\n{idade} \r\n{EstadoCivil}\r\n{idade}");