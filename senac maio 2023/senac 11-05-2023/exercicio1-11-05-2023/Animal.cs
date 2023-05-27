using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio1_11_05_2023
{
    public class Animal
    {
        public string Nome {get;set;}
        public string Dono {get;set;}

        public string CategoriaNome {get;set;}
        
        public Animal(string nome, string dono)
        {
            Nome = nome;
            Dono = dono;
        }
        
        public void NomearCategoria(int categoria)
        {
            switch (categoria)
            {
                case 1:
                    CategoriaNome = "Cachorro";
                
                    break;
                case 2:
                    CategoriaNome = "Gato";
                
                    break;
                case 3:
                    CategoriaNome = "Vaca";
                
                    break;
                case 4:
                    CategoriaNome = "Cavalo";
                
                    break;
            }
        }
    }
}