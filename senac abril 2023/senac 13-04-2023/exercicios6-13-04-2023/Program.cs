using System;

namespace exercicios6_13_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Imprimir apenas números primos de 1 a 1000

            int nPrimo;

            for (int contador = 1; contador <= 1000; contador++) {
                nPrimo = 0;
                for (int contador2 = contador; contador2 >= 1; contador2--) {
                    if (contador == 1)
                    {
                        nPrimo++;
                    }
                    if (contador % contador2 == 0)
                    {
                        nPrimo++;
                    }
                    //Console.WriteLine($"O número {contador} pode ser dividido por {nPrimo} números!");
                }
                if (nPrimo == 2)
                    {
                        Console.WriteLine(contador);
                    }
            }
        }
    }
}
