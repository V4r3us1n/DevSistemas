using System;

namespace exercicios3_13_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando as Variáveis

            for (int valor1 = 1; valor1 <= 10; valor1++) {
                Console.WriteLine($"Tabuada do {valor1}");
                for (int valor2 = 0; valor2 <= 10; valor2++) {
                    if (valor2 != 10)
                    {
                    Console.WriteLine($"{valor1} x {valor2} = {valor1 * valor2}");
                    }
                    else
                    {
                    Console.WriteLine($"{valor1} x {valor2} = {valor1 * valor2}\n");
                    }
                }
            }
            Console.WriteLine("FIM DA TABUADA!");
        }
    }
}
