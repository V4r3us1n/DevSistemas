using System;

namespace exercicios11_13_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Imprimir valores de 1 a 1000, separando eles por -, só quando for 1000 finaliza com .

            int contador = 1;

            while (contador <= 1000)
            {
                if(contador < 1000)
                {
                    Console.Write($"{contador}-");
                }
                else
                {
                    Console.WriteLine($"{contador}.");
                }
                contador++;
            }
            Console.WriteLine("FIM DO PROGRAMA!");
        }
    }
}
