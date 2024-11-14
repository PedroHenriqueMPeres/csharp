using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RWorld.classes
{
    public class RpgClasse
    {
        public string nome;
        public int idade;
        public string narmadura;
        public string nIA;

        public void Atacar(){
            Console.WriteLine($"O {nome} está atacando");
        }
        public void Defender(){
            Console.WriteLine($"O {nome} está Defendendo");
        }
        public void RestaurandoArmadura(){
            Console.WriteLine($"O {nome} está restaurando a armadura");
        }
    }
}