using System;

namespace exercicios29_13_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicitando número inteiro para realizar seu fatorial

            int valor1, fatorialNum = 1;
            string fatorialString = "";

            Console.Write("Digite um número inteiro... ");
            valor1 = Int32.Parse(Console.ReadLine());

            for (int contador = valor1; contador >= 1; contador--) {
                if  (contador == 1)
                {
                    fatorialString += $"{contador} = ";
                }
                else
                {
                    fatorialString += $"{contador} x ";   
                }

                fatorialNum *= contador;
            }

            Console.WriteLine($"O fatorial de {valor1} é... ");
            Console.WriteLine($"{fatorialString}{fatorialNum}");

            Console.WriteLine("FIM DO PROGRAMA!");
        }
    }
}
