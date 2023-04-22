using System;

namespace exercicios19_13_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Imprimindo valores de 1000 a 0

            int contador = 1000;

            do {
                Console.WriteLine(contador);
                contador--;
            } while (contador >= 0);

            Console.WriteLine("FIM DO PROGRAMA!");
        }
    }
}
