using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PilaresPOO.Classes.Aprendizagem
{
    public abstract class Veiculos
    {
        public string marca;
        public string modelo;
        public string cor;
        public string potencia;
        public int qntportas;

        public void Ligar(){
            Console.WriteLine($"Veiculo ligando");
        }
        public void Desligar(){
            Console.WriteLine($"Desligando veiculo");
        }
        public void Buzinar(){
            Console.WriteLine($"Bibiii");
        }

    }
}