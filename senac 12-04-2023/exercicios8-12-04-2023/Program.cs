using System;

namespace exercicios8_12_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicitando 5 valores inteiros

            int valor1, valor2, valor3, valor4, valor5;
            string par_impar = "";

            Console.Write("Digite o Primeiro Valor... ");
            valor1 = Int32.Parse(Console.ReadLine());

            Console.Write("Digite o Segundo Valor... ");
            valor2 = Int32.Parse(Console.ReadLine());

            Console.Write("Digite o Terceiro Valor... ");
            valor3 = Int32.Parse(Console.ReadLine());

            Console.Write("Digite o Quarto Valor... ");
            valor4 = Int32.Parse(Console.ReadLine());

            Console.Write("Digite o Quinto Valor... ");
            valor5 = Int32.Parse(Console.ReadLine());

            //Verificando se o número é impar ou par...

            //Valor 1

            if (valor1 % 2 == 0) {
                par_impar = "PAR";
            }
            else
            {
                par_impar = "IMPAR";
            }

            Console.WriteLine($"O valor {valor1} é {par_impar}!");

            //Valor 2

            if (valor2 % 2 == 0) {
                par_impar = "PAR";
            }
            else
            {
                par_impar = "IMPAR";
            }

            Console.WriteLine($"O valor {valor2} é {par_impar}!");

            //Valor 3

            if (valor3 % 2 == 0) {
                par_impar = "PAR";
            }
            else
            {
                par_impar = "IMPAR";
            }

            Console.WriteLine($"O valor {valor3} é {par_impar}!");

            //Valor 4

            if (valor4 % 2 == 0) {
                par_impar = "PAR";
            }
            else
            {
                par_impar = "IMPAR";
            }

            Console.WriteLine($"O valor {valor4} é {par_impar}!");

            //Valor 5

            if (valor5 % 2 == 0) {
                par_impar = "PAR";
            }
            else
            {
                par_impar = "IMPAR";
            }

            Console.WriteLine($"O valor {valor5} é {par_impar}!");
        }
    }
}
