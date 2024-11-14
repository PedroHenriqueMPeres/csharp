using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PilaresPOO.Classes.Aprendizagem
{
    public abstract class Pessoa
    {
        public string nome;
        public int idade;
        public string cpf;
        public float peso;
        public float altura;

        public void Envelhercer(){
            idade++;
        }
        public void Engordar(float _kg){
            peso = peso + _kg;
        }
        public void Emagrecer(float _kg){
            peso = peso - _kg;
        }
        
    }
}