using System;

namespace exercicios4_13_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicializar o Programa

            for (int contador = 0; contador <= 1000; contador++) {
                if (contador % 2 == 0) {
                    Console.WriteLine(contador);
                }
            }
            Console.WriteLine("FIM DO PROGRAMA!");
        }
    }
}
