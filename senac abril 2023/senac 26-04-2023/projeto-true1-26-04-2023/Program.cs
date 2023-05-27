using System;

namespace projeto_true1_26_04_2023
{
    class Program
    {
        static int varGlobal = 0;

        static void Main(string[] args)
        {
            //Métodos
            Console.Write("Digite um Número: ");
            var n1 = Int32.Parse(Console.ReadLine());

            Console.Write("Digite outro Número: ");
            var n2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"A soma entre {n1} e {n2} é {Soma(ref n1, n2)}");

            Console.WriteLine(n1);

            int[] arrayInteiro = new int[2];

            //Console.Write("Digite um valor para subtrair: ");
            //arrayInteiro[0] = Int32.Parse(Console.ReadLine());
            arrayInteiro[0] = 12;

            //Console..Write("Digite outro valor para subtrair: ");
            //arrayInteiro[1] = Int32.Parse(Console.ReadLine());
            arrayInteiro[1] = 13;

            Console.WriteLine($"A subtração entre {arrayInteiro[0]} e {arrayInteiro[1]} é {Subtracao(ref arrayInteiro[0], arrayInteiro[1])}");
            Console.WriteLine(arrayInteiro[0]);
            varGlobal++;
            Console.WriteLine($"Foram executados {varGlobal} Métodos!");
            Console.Clear();
            Console.WriteLine("Terminal Limpo");
        }

        static int Soma(ref int valor1, int valor2)
        {
            valor1 = valor1 + valor2;
            varGlobal++;
            return valor1;
        }

        static int Subtracao(ref int valor1, int valor2)
        {
            valor1 = valor1 + valor2;
            varGlobal++;
            return valor1;
        }
    }
}
