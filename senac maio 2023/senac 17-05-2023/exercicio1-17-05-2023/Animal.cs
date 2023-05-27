using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio1_17_05_2023
{
    public abstract class Animal
    {
        public string NomeAnimal {get;set;}
        public string DonoAnimal {get;set;}
        protected string CategoriaAnimal {get;set;}

        public Animal (string nomeAnimal, string donoAnimal)
        {
            NomeAnimal = nomeAnimal;
            DonoAnimal = donoAnimal;
        }

        public abstract string AdicionarCategoria();

    }
}