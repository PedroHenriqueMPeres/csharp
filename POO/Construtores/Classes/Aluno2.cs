using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores.Classes
{
    public class Aluno2
    {
        public string Nome;
        public int cpf;

        public Aluno2(){ }
        public Aluno2(string _chuchu){
            Nome = _chuchu;
        }
        public Aluno2(string _nome, int _cpf){
            Nome = _nome;
            cpf = _cpf;
        }
    }
}