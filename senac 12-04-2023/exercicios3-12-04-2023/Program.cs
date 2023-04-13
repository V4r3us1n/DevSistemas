using System;

namespace exercicios3_12_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicitando valores ao Usuário

            double valorA, valorB, valorC;

            Console.Write("Informe o valor de A... ");
            valorA = Double.Parse(Console.ReadLine());

            Console.Write("Informe o valor de B... ");
            valorB = Double.Parse(Console.ReadLine());

            //Trocando os valores...

            valorC = valorB;
            valorB = valorA;
            valorA = valorC;

            //Exibindo Resultado...

            Console.WriteLine($"O Valor A foi trocado para {valorA} e o Valor B foi trocado para {valorB}!");
        }
    }
}
