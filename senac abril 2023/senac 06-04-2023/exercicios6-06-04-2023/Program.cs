using System;

namespace exercicios6_06_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicitando a Idade

            Console.Write("Digite sua Idade...  ");

            var x = Console.ReadLine();

            byte idade = Byte.Parse(x);

            if (idade > 17)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"Você tem {idade} anos, você é ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("MAIOR DE IDADE");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"Você tem {idade} anos, você é ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("MENOR DE IDADE");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("!");
            }
        }
    }
}
