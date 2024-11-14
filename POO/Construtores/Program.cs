using System;
using System.Collections.Generic;
using Construtores.Classes;

Console.Clear();

Aluno Ph = new Aluno("Ph");
Ph.cpf = 545727948;

Aluno2 J = new Aluno2("J");
J.cpf = 712798424;

Aluno3 F = new Aluno3("F");
F.cpf = 832353556;


Console.WriteLine(Ph.Nome);
Console.WriteLine(Ph.cpf);
Console.WriteLine(J.Nome);
Console.WriteLine(J.cpf);
Console.WriteLine(F.Nome);
Console.WriteLine(F.cpf);




// namespace RPGPOO
// {
//     public class Personagem
//     {
//         
//         public string Nome { get; set; }
//         public int Idade { get; set; }
//         public string Armadura { get; set; }
//         public string IA { get; set; }

//         
//         public void Atacar()
//         {
//             Console.WriteLine("O personagem atacou!");
//         }

//         
//         public string Defender()
//         {
//             return "O personagem defendeu!";
//         }

//         
//         public void RestaurarArmadura()
//         {
//             Console.WriteLine("O personagem restaurou a armadura!");
//         }

//         
//         public void ExibirInformacoes()
//         {
//             Console.WriteLine($"{Nome},");
//             Console.WriteLine($"{Idade},");
//             Console.WriteLine($"{Armadura},");
//             Console.WriteLine($"{IA}");
//         }
//     }

//     class Program
//     {
//         static List<Personagem> personagens = new List<Personagem>(); // Lista de personagens cadastrados

//         static void Main(string[] args)
//         {
//             int opcao;
//             do
//             {
//                 
//                 Console.Clear();
//                 Console.WriteLine("===== MENU =====");
//                 Console.WriteLine("1 - Cadastrar Personagem");
//                 Console.WriteLine("2 - Mostrar Personagens Cadastrados");
//                 Console.WriteLine("3 - Sair");
//                 Console.Write("Escolha uma opção: ");

//                 
//                 opcao = int.Parse(Console.ReadLine());

//                 switch (opcao)
//                 {
//                     case 1:
//                         CadastrarPersonagem();
//                         break;
//                     case 2:
//                         MostrarPersonagens();
//                         break;
//                     case 3:
//                         Console.WriteLine("Saindo... Até logo!");
//                         break;
//                     default:
//                         Console.WriteLine("Opção inválida! Tente novamente.");
//                         break;
//                 }

//                 
//                 if (opcao != 3)
//                 {
//                     Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
//                     Console.ReadKey();
//                 }

//             } while (opcao != 3);
//         }

//         
//         static void CadastrarPersonagem()
//         {
//             Personagem personagem = new Personagem();

//             
//             Console.Clear();
//             Console.Write("Digite o nome do seu personagem: ");
//             personagem.Nome = Console.ReadLine();

//             Console.Write("Digite a idade do seu personagem: ");
//             personagem.Idade = int.Parse(Console.ReadLine());

//             Console.Write("Informe o nome da armadura do personagem: ");
//             personagem.Armadura = Console.ReadLine();

//             Console.Write("Informe a I.A que o personagem utiliza: ");
//             personagem.IA = Console.ReadLine();

//             
//             personagens.Add(personagem);

//             Console.WriteLine("\nPersonagem cadastrado com sucesso!");
//         }

//         
//         static void MostrarPersonagens()
//         {
//             Console.Clear();
//             if (personagens.Count == 0)
//             {
//                 Console.WriteLine("Nenhum personagem cadastrado.");
//             }
//             else
//             {
//                 Console.WriteLine("Personagens Cadastrados:");
//                 foreach (var personagem in personagens)
//                 {
//                     personagem.ExibirInformacoes();
//                     Console.WriteLine("-------------------------");
//                 }
//             }
//         }
//     }
// }


