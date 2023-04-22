using System;

namespace exercicios3_05_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um caracter... ");
            string a = Console.ReadLine();
            Console.WriteLine("\n\n");

            //TRIâNGULO

            Console.WriteLine($"    {a}    ");
            Console.WriteLine($"   {a} {a}   ");
            Console.WriteLine($"  {a}   {a}  ");
            Console.WriteLine($" {a}     {a} ");
            Console.WriteLine($"{a}{a}{a}{a}{a}{a}{a}{a}{a}");
            Console.WriteLine("\n\n");

            //QUADRADO

            Console.WriteLine($"{a}{a}{a}{a}{a}{a}{a}{a}{a}");
            Console.WriteLine($"{a}       {a}");
            Console.WriteLine($"{a}       {a}");
            Console.WriteLine($"{a}       {a}");
            Console.WriteLine($"{a}{a}{a}{a}{a}{a}{a}{a}{a}");
            Console.WriteLine("\n\n");

            //C#

            Console.WriteLine($"{a}{a}{a}{a}    {a}  {a}");
            Console.WriteLine($"{a}     {a}{a}{a}{a}{a}{a}{a}{a}");
            Console.WriteLine($"{a}       {a}  {a}");
            Console.WriteLine($"{a}     {a}{a}{a}{a}{a}{a}{a}{a}");
            Console.WriteLine($"{a}{a}{a}{a}    {a}  {a}");
            Console.WriteLine("\n\n");
        }
    }
}
