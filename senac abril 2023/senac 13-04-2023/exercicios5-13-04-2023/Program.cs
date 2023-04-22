using System;

namespace exercicios5_13_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicializar o Programa

            for (int contador = 1; contador <= 1000; contador++) {
                if (contador % 2 == 1) {
                    Console.WriteLine(contador);
                }
            }
            Console.WriteLine("FIM DO PROGRAMA!");
        }
    }
}
