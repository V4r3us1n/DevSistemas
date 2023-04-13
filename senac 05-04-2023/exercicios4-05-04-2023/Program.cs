using System;

namespace exercicios4_05_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Informando a Primeira Nota

            //Console.Write("Insira a Primeira Nota... ");
            const double nota_1 = 6.8;

            //Informando a Segunda Nota

            //Console.Write("Insira a Segunda Nota... ");
            const double nota_2 = 6.8;

            //Informando a Terceira Nota

            //Console.Write("Insira a Terceira Nota... ");
            const double nota_3 = 4.3;

            //Informando a Quarta Nota

            //Console.Write("Insira a Quarta Nota... ");
            const double nota_4 = 2.2;

            //Calculando a Média das Notas

            const double media = (nota_1 + nota_2 + nota_3 + nota_4) / 4;

            //Impriminto o Resultado

            Console.WriteLine($"Sua Média, de acordo com as notas que foram inseridas ('{nota_1}', '{nota_2}', '{nota_3}' e '{nota_4}'), ficou '{media}'!"); 
        }
    }
}
