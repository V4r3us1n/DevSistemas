using System;

namespace exercicios8_06_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicitando um Número Inteiro

            Console.Write("Digite um Número Inteiro... ");

            var x = Console.ReadLine();

            int n1 = Int32.Parse(x);

            //Somando o Valor com 2
            int soma = n1 + 2;
            Console.WriteLine($"A soma entre {n1} e 2 é {soma}!\n");

            //Subtraindo o Valor com 2
            int subtracao = n1 - 2;
            Console.WriteLine($"A subtração entre {n1} e 2 é {subtracao}!\n");

            //Dividindo o Valor com 2
            decimal divisao = (decimal)n1 / 2;
            Console.WriteLine($"A divisão entre {n1} e 2 é {divisao}!\n");

            //Multiplicando o Valor com 2
            int multiplicacao = n1 * 2;
            Console.WriteLine($"A multiplicação entre {n1} e 2 é {multiplicacao}");
        }
    }
}
