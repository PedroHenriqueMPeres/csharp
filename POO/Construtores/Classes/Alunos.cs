using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores.Classes
{
    public class Aluno
    {
        public string Nome;
        public int cpf;

        public Aluno(string _nome, int _cpf){
            Nome = _nome;
            cpf = _cpf;
        }
        public Aluno(){ }
        public Aluno(string chuchu){
            Nome = chuchu;
        }
    }
}