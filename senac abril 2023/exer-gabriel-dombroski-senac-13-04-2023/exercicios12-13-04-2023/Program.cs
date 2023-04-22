using System;

namespace exercicios12_13_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Imprimir números pares até o 1000

            int contador = 0;

            while (contador <= 1000)
            {
                if (contador % 2 == 0)
                {
                    Console.WriteLine(contador);
                }
                contador++;
            }

            Console.WriteLine("FIM DO PROGRAMA!");
        }
    }
}
