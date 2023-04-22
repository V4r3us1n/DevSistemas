using System;

namespace exercicios1_13_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando as Tabelas

            //Tabela Verdade 1

            Console.WriteLine("=========================");

            Console.WriteLine("TABELA VERDADE 1: \\n");
            Console.WriteLine("A B !A");
            Console.WriteLine("V V  F");
            Console.WriteLine("V F  F");
            Console.WriteLine("F V  V");
            Console.WriteLine("F F  V");

            Console.WriteLine("");

            Console.WriteLine("=========================");

            //Tabela Verdade 2
            Console.WriteLine("TABELA VERDADE 2:");
            Console.WriteLine("A B A&&B !A");
            Console.WriteLine("V V  V    F");
            Console.WriteLine("V F  F    F");
            Console.WriteLine("F V  F    V");
            Console.WriteLine("F F  F    V");

            //Tabela Verdade 3

            Console.WriteLine("TABELA VERDADE 3:");
            Console.WriteLine("A B A||B !B");
            Console.WriteLine("V V  V    F");
            Console.WriteLine("V F  V    V");
            Console.WriteLine("F V  V    F");
            Console.WriteLine("F F  F    V");

            Console.WriteLine("");

            Console.WriteLine("=========================");

            //Tabela Verdade 4

            Console.WriteLine("TABELA VERDADE 3:");
            Console.WriteLine("A B A&&!B !B");
            Console.WriteLine("V V   F     F");
            Console.WriteLine("V F   V     V");
            Console.WriteLine("F V   F     F");
            Console.WriteLine("F F   F     V");

            Console.WriteLine("");
        }
    }
}
