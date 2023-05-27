using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio1_17_05_2023
{
    public class Vaca : Animal
    {
        public Vaca (string nomeAnimal, string donoAnimal) : base(nomeAnimal, donoAnimal)
        {
            NomeAnimal = nomeAnimal;
            DonoAnimal = donoAnimal;
        }

        public override string AdicionarCategoria()
        {
            CategoriaAnimal = "Vaca";

            return CategoriaAnimal;
        }
    }
}