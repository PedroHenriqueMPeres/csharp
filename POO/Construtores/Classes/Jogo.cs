using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores.Classes
{
    public class Veiculo
    {
        public string marca;
        public string modelo;
        public int ano;
        public string cor;
        public void ExibirDados(){
            Console.WriteLine(@$"
            Marca:{marca}
            modelo:{modelo}
            Ano:{ano}
            Cor:{cor}");
            
        }

public  Veiculo(string mc, string md, int an, string cr){
    marca = mc;
    modelo = md;
    ano = an;
    cor= cr;
}
    public void VeiculoC(){
        Console.WriteLine(@"Veiculo criado com sucesso!!");
    }

}
}  
    public class jogo{
        public string nome;
        public string lançamento;
        public string genero;
        public string preço;
    
    public jogo(string n, string l, string g, string p)
    {

        nome = n;
        lançamento = l;
        genero = g;
        preço = p;
      }
      public void ExibirJogos(){
        
            Console.WriteLine(@$"
            Marca: {nome}
            modelo: {lançamento}
            Ano: {genero}
            Cor: {preço}");
            
        }
      }