using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio1_18_05_2023
{
    public class Cachorro : Animal
    {
        public Cachorro (string nomeAnimal, string donoAnimal) : base(nomeAnimal, donoAnimal)
        {
            NomeAnimal = nomeAnimal;
            DonoAnimal = donoAnimal;
        }

        public bool Caminhando(string respostaAndando)
        {
            if (respostaAndando.ToUpper() == "S")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string AdicionarCategoria()
        {
            CategoriaAnimal = "Cachorro";
            return CategoriaAnimal;
        }
    }
}