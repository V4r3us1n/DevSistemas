using System;

namespace exercicios22_13_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Imprimir valores de 1 a 1000, separando eles por -, só quando for 1000 finaliza com .

            int contador = 1;

            do {
                if(contador < 1000)
                {
                    Console.Write($"{contador}-");
                }
                else
                {
                    Console.WriteLine($"{contador}.");
                }
                contador++;
            } while (contador <= 1000);

            Console.WriteLine("FIM DO PROGRAMA!");
        }
    }
}
