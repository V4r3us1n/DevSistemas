using System;

namespace exercicios7_12_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicitando 3 valores
            int valor1, valor2, valor3;
            string maiorValor = "";

            Console.Write("Informe o Primeiro Valor... ");
            valor1 = Int32.Parse(Console.ReadLine());

            Console.Write("Informe o Segundo Valor... ");
            valor2 = Int32.Parse(Console.ReadLine());

            Console.Write("Informe o Terceiro Valor... ");
            valor3 = Int32.Parse(Console.ReadLine());

            //Verificando qual deles é o maior...

            if (valor1 > valor2 && valor1 > valor3)
            {
                maiorValor = $"{valor1}";
            }
            else if (valor2 > valor3 && valor2 > valor1)
            {
                maiorValor = $"{valor2}";
            }
            else if (valor3 > valor2 && valor3 > valor1)
            {
                maiorValor = $"{valor3}";
            }
            else if (valor1 == valor2 || valor2 == valor3 || valor1 == valor3)
            {
                maiorValor = "Nenhum";
            }

            Console.WriteLine($"O maior dos valores inseridos é {maiorValor}!");
        }
    }
}
