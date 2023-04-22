using System;

namespace exercicios24_13_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Imprimindo todos os números impares de 1 a 1000

            int contador = 1;

            do {
                if (contador % 2 == 1)
                {
                    Console.WriteLine(contador);
                }

                contador++;
            } while (contador <= 1000);

            Console.WriteLine("FIM DO PROGRAMA!");
        }
    }
}
