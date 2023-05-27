using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio1_18_05_2023
{
    public class Peixe : Animal
    {
        public Peixe (string nomeAnimal, string donoAnimal) : base(nomeAnimal, donoAnimal)
        {
            NomeAnimal = nomeAnimal;
            DonoAnimal = donoAnimal;
        }

        public override string AdicionarCategoria()
        {
            CategoriaAnimal = "Peixe";

            return CategoriaAnimal;
        }
    }
}