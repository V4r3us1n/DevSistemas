using System;

namespace exercicios25_13_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Imprimir todos os números primos de 1 até 1000

            int contador = 1, contador2, nPrimo;

            do {
                nPrimo = 0;
                contador2 = contador;

                do {
                    if (contador == 1)
                    {
                        nPrimo++;
                    }
                    if (contador % contador2 == 0)
                    {
                        nPrimo++;
                    }

                    contador2--;
                } while (contador2 >= 1);
                
                if (nPrimo == 2)
                {
                    Console.WriteLine(contador);
                }

                contador++;
            } while (contador <= 1000);
        }
    }
}
