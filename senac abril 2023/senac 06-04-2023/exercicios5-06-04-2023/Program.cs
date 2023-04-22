using System;

namespace exercicios5_06_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicitando o Tamanho dos 3 Lados do Triângulo

            string triangulo;

            Console.Write("Informe o comprimento, em cm, do Primeiro Lado do Triângulo... ");
            decimal lado1 = Decimal.Parse(Console.ReadLine());

            Console.Write("Informe o comprimento, em cm, do Segundo Lado do Triângulo... ");
            decimal lado2 = Decimal.Parse(Console.ReadLine());

            Console.Write("Informe o comprimento, em cm, do Terceiro Lado do Triângulo... ");
            decimal lado3 = Decimal.Parse(Console.ReadLine());

            if (lado1 != lado2 && lado2 != lado3 && lado1 != lado3)
            {
                triangulo = "TRIÂNGULO ESCALENO";
            }
            else if (lado1 != lado2 || lado1 != lado3 || lado2 != lado3)
                {
                    triangulo = "TRIÂNGULO ISÓSCELES";
                }
                else
                {
                    triangulo = "TRIÂNGULO EQUILÁTERO";
                }

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("De acordo com os valores informados, se trata de um ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(triangulo);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("!");
        }
    }
}
