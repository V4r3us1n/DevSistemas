using System;

namespace exercicios3_p2_13_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Realizando Contagem

            for (int contador = 1; contador <= 1000; contador++) {
                if (contador < 1000)
                {
                    Console.Write($"{contador}-");
                }
                else
                {
                    Console.Write($"{contador}.");
                }
            }
            Console.WriteLine("FIM DO PROGRAMA!");
        }
    }
}
