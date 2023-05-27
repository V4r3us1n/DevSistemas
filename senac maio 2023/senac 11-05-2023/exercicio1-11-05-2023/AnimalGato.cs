using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio1_11_05_2023
{
    public class AnimalGato:Animal
    {  
        public AnimalGato(string nome, string dono) : base(nome, dono)
        {
            Nome = nome;
            Dono = dono;
        }

        public void AdicionarCategoria(string categoriaNome)
        {
            CategoriaNome = categoriaNome;
        }

    }
}