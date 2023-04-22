using System;

namespace exercicios13_12_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicitar o número para Tabuada...

            int valor1;

            Console.Write("Informe um número que você gostaria de saber a tabuada... ");
            valor1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"{valor1} x  1 = {valor1 * 1}");
            Console.WriteLine($"{valor1} x  2 = {valor1 * 2}");
            Console.WriteLine($"{valor1} x  3 = {valor1 * 3}");
            Console.WriteLine($"{valor1} x  4 = {valor1 * 4}");
            Console.WriteLine($"{valor1} x  5 = {valor1 * 5}");
            Console.WriteLine($"{valor1} x  6 = {valor1 * 6}");
            Console.WriteLine($"{valor1} x  7 = {valor1 * 7}");
            Console.WriteLine($"{valor1} x  8 = {valor1 * 8}");
            Console.WriteLine($"{valor1} x  9 = {valor1 * 9}");
            Console.WriteLine($"{valor1} x 10 = {valor1 * 10}");

            Console.WriteLine("\nFIM DA TABUADA!");
        }
    }
}
