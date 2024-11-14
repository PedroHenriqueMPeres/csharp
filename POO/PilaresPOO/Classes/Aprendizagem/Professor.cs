using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PilaresPOO.Classes.Aprendizagem
{
    public class Professor : Pessoa
    {
        public int Nif;
        public float salario;
        public string horario;
        public Professor(int nif)
        {
            Nif = nif;
        }
    }
}