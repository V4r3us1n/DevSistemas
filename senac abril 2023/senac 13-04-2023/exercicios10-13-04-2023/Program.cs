using System;

namespace exercicios10_13_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Realizando a tabuada

            int contador1 = 1, contador2;

            while (contador1 <= 10)
            {
                contador2 = 1;
                Console.WriteLine($"Tabuada do {contador1}");
                while (contador2 <= 10)
                {
                    if(contador2 < 10)
                    {
                        Console.WriteLine($"{contador1} x {contador2} = {contador1 * contador2}");
                    }
                    else
                    {
                        Console.WriteLine($"{contador1} x {contador2} = {contador1 * contador2}\n");
                    }
                    contador2++;
                }
                contador1++;
            }

            Console.WriteLine("FIM DO PROGRAMA!");
        }
    }
}
