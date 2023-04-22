using System;

namespace exercicios9_06_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicitando um Número Inteiro

            Console.Write("Digite um Número Inteiro... ");

            var x = Console.ReadLine();
            int n1 = Int32.Parse(x);

            //Verificando se o Número é PAR

            if (n1 % 2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"O número {n1} é ");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("IMPAR");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"O número {n1} é ");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("IMPAR");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("!");
            }
        }
    }
}
