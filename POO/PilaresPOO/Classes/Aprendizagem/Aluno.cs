using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PilaresPOO.Classes.Aprendizagem
{
    public class Aluno : Pessoa
    {
        public string matricula;
        public float média;
        public string curso;

        public void calcmédia(float calcmédia){
            média = média/calcmédia;
        }
    }
}