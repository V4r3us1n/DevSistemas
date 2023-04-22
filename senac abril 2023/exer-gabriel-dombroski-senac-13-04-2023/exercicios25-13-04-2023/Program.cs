using System;

namespace exercicios26_13_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicitando um número

            int valor1, contador = 1;

            Console.Write("Digite um número inteiro... ");
            valor1 = Int32.Parse(Console.ReadLine());

            do {
                if (contador == 1)
                {
                    Console.WriteLine($"Esse número é {contador} vez o valor de {valor1}: {valor1 * contador}");
                }
                else
                {
                    Console.WriteLine($"Esse número é {contador} vezes o valor de {valor1}: {valor1 * contador}");   
                }
                contador++;
            } while (contador <= 1000);

            Console.WriteLine("FIM DO PROGRAMA!");
        }
    }
}
