using System;

namespace exercicios15_13_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicitando um número

            int valor1, contador = 1;

            Console.Write("Digite um número inteiro... ");
            valor1 = Int32.Parse(Console.ReadLine());

            while (contador <= 1000)
            {
                if (contador == 1)
                {
                    Console.WriteLine($"Esse número é {contador} vez o valor de {valor1}: {valor1 * contador}");
                }
                else
                {
                    Console.WriteLine($"Esse número é {contador} vezes o valor de {valor1}: {valor1 * contador}");   
                }
                contador++;
            }
            Console.WriteLine("FIM DO PROGRAMA!");
        }
    }
}
