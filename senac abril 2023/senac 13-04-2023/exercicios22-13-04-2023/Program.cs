using System;

namespace exercicios23_13_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Imprimir números pares até o 1000

            int contador = 1;

            do {
                if (contador % 2 == 0)
                {
                    Console.WriteLine(contador);
                }
                contador++;
            } while (contador <= 1000);

            Console.WriteLine("FIM DO PROGRAMA!");
        }
    }
}
