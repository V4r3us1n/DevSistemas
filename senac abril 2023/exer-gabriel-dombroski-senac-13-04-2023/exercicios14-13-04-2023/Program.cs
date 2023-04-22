using System;

namespace exercicios14_13_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Imprimir todos os números primos de 1 até 1000

            int contador = 1, contador2, nPrimo;

            while (contador <= 1000)
            {
                nPrimo = 0;
                contador2 = contador;
                while (contador2 >= 1)
                {
                    if (contador == 1)
                    {
                        nPrimo++;
                    }
                    if (contador % contador2 == 0)
                    {
                        nPrimo++;
                    }

                    contador2--;
                }
                if (nPrimo == 2)
                {
                    Console.WriteLine(contador);
                }

                contador++;
            }

            Console.WriteLine("FIM DO PROGRAMA!");
        }
    }
}
