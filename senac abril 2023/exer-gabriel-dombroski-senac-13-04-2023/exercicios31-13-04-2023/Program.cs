using System;

namespace exercicios31_13_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variáveis iniciais

            int valor1 = 0, valor2 = 1, valor3 = 0;

            while (valor1 < 100 && valor2 < 100 && valor3 < 100) {
                if (valor3 + valor2 > 100)
                {
                    if (valor1 > valor2)
                    {
                        Console.WriteLine($"{valor2}, {valor1}.");
                    }
                    else
                    {
                        Console.WriteLine($"{valor1}, {valor2}.");
                    }
                }
                else
                {
                    Console.Write($"{valor1}, {valor2}, ");
                }

                valor3 = valor1 + valor2;
                valor1 = valor3;
                valor2 = valor2 + valor3;
            }
            Console.WriteLine("\nFIM DO PROGRAMA!");
        }
    }
}
