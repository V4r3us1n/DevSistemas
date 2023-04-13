using System;

namespace exercicios1_06_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicitando os Valores...
            
            Console.Write("Digite um número com vírgula... ");
            decimal n1 = Decimal.Parse(Console.ReadLine());

            Console.Write("Digite outro número com vírgula... ");
            decimal n2 = Decimal.Parse(Console.ReadLine());

            //Realizando as Operações Aritméticas...

            Console.WriteLine("Realizando Operações... ");

            decimal soma = n1 + n2;

            decimal subtracao = n1 - n2;

            decimal multiplicacao = n1 * n2;

            decimal divisao = n1 / n2;

            //Imprimindo as Operações para o Usuário

            Console.WriteLine($"A soma entre {n1} e {n2} é {soma}!\n");

            Console.WriteLine($"A subtração entre {n1} e {n2} é {subtracao}!\n");

            Console.WriteLine($"A divisão entre {n1} e {n2} é {divisao}!\n");

            Console.WriteLine($"A multiplicação entre {n1} e {n2} é {multiplicacao}!\n");

            Console.WriteLine("Fim da Aplicação!");

        }
    }
}
