using System;

namespace exercicios1_06_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarando Variáveis do Tipo String

            string x = "76";

            string y = "24";

            //Convertendo as Strings Para Int e Decimal

            int n1 = Convert.ToInt32(x);

            decimal n2 = Decimal.Parse(y);

            decimal soma = n1 + n2;

            Console.WriteLine($"A soma entre {n1} e {n2} é {soma}!");

        }
    }
}
