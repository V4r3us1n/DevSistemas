using System;

namespace exercicios7_13_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicitando Número

            int valor1;

            Console.Write("Digite um valor... ");
            valor1 = Int32.Parse(Console.ReadLine());

            //Multiplicar por até 1000

            for (int contador = 1; contador <= 1000; contador++) {
                if (contador == 1)
                {
                    Console.WriteLine($"Esse é {contador} vez o valor de {valor1}: {valor1 * contador}");
                }
                else
                {
                    Console.WriteLine($"Esse é {contador} vezes o valor de {valor1}: {valor1 * contador}");   
                }
            }

            Console.WriteLine("FIM DO PROGRAMA!");
        }
    }
}
