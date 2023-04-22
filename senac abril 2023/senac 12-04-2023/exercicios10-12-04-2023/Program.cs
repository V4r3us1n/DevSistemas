using System;

namespace exercicios10_12_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicitando o Ano

            int ano;

            Console.Write("Informe o ano... ");
            ano = Int32.Parse(Console.ReadLine());

            //Verificando se é Bissexto

            if (ano % 4 == 0)
            {
                Console.WriteLine($"O ano {ano} é BISSEXTO!");
            }
            else
            {
                Console.WriteLine($"O ano {ano} NÃO é BISSEXTO!");
            }
        }
    }
}
