using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.classes
{
    public class Calcular
    {
        public float numero1;
        public float numero2;
----++
        public void Somar(float resultado){
            resultado = numero1 + numero2; 
            Console.WriteLine($"Soma:{resultado}");
        }

        public void Subtrair(float resultado){
            resultado = numero1 - numero2; 
            Console.WriteLine($"Subitração:{resultado}");
        }
        public void Multiplicar(float resultado){
            resultado = numero1 * numero2; 
            Console.WriteLine($"Multiplicação:{resultado}");
        }
        public void Dividir(float resultado){
            resultado = numero1 / numero2; 
            Console.WriteLine($"Divisão:{resultado}");
        }
    }
}