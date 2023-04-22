using System;

namespace exercicios1_05_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercício 1, Triângulo #

            Console.WriteLine("       #       ");
            Console.WriteLine("      ###      ");
            Console.WriteLine("     #####     ");
            Console.WriteLine("    #######    ");
            Console.WriteLine("   #########   ");
            Console.WriteLine("  ###########  ");
            Console.WriteLine(" ############# ");
            Console.WriteLine("###############");
            Console.WriteLine("\n\n\n");

            //Quadrado #

            Console.WriteLine("###############");
            Console.WriteLine("###############");
            Console.WriteLine("###############");
            Console.WriteLine("###############");
            Console.WriteLine("###############");
            Console.WriteLine("###############");
            Console.WriteLine("###############");
            Console.WriteLine("\n\n\n");

            //C# feito de #

            //Linha 1
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write("#####");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("    ");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("#");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("#");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("  ");

            //Linha 2
            Console.Write("");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write("#");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("      ");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("########");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("");

            //Linha 3
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write("#");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("        ");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("#");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("#");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("  ");

            //Linha 4
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write("#");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("      ");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("########");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("");

            //Linha 5
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write("#####");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("#");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("#");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("  \n\n\n");


            Console.WriteLine("Por favor digite seu nome: ");
            string nome = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Olá ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(nome);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("!");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Quantos anos você tem? ");
            var idade = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Uau! Você tem ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(idade);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" anos, PARABÉNS!");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
