using System;

namespace exercicios7_06_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicitando um Número Inteiro

            Console.Write("Digite um número inteiro... ");

            var x = Console.ReadLine();

            int n1 = Int32.Parse(x);

            //Calculando o dobro do Número

            int dobro_n1 = n1 * 2;
            Console.WriteLine($"O dobro de {n1} é {dobro_n1}!");

            //Elevar ao Quadrado o Dobro do Número

            int quadrado_dobro_n1 = dobro_n1 * dobro_n1;
            Console.WriteLine($"O quadrado do dobro de {n1} é {quadrado_dobro_n1}!");

            //Somar 1 ao Quadrado do Dobro do Número

            int quadrado_dobro_n1_mais1 = quadrado_dobro_n1 + 1;

            Console.WriteLine($"O quadrado do dobro de {n1} somado com +1 é {quadrado_dobro_n1_mais1}");
        }
    }
}
