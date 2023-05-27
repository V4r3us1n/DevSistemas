using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio1_18_05_2023
{
    public class Relatorio
    {
        public void ExibirRelatorio (Animal animal)
        {
            Console.WriteLine("========== RELATÓRIO DE CADASTRO DE ANIMAL ==========");
            Console.WriteLine("");
            Console.WriteLine($"Nome: {animal.NomeAnimal}");
            Console.WriteLine($"Dono: {animal.DonoAnimal}");
            Console.WriteLine($"Categoria: {animal.AdicionarCategoria()}");
        }
    }
}