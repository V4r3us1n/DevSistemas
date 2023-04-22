using System;

namespace exercicios16_13_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criar Programa que imprima valores de 1000 a 0

            int contador = 1000;

            while (contador >= 0)
            {
                Console.WriteLine(contador);

                contador--;
            }

            Console.WriteLine("FIM DO PROGRAMA!");
        }
    }
}
