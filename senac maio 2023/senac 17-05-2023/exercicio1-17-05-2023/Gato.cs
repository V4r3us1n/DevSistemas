using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio1_17_05_2023
{
    public class Gato : Animal
    {
        public Gato (string nomeAnimal, string donoAnimal) : base(nomeAnimal, donoAnimal)
        {
            NomeAnimal = nomeAnimal;
            DonoAnimal = donoAnimal;
        }

        public override string AdicionarCategoria()
        {
            CategoriaAnimal = "Gato";

            return CategoriaAnimal;
        }
    }
}