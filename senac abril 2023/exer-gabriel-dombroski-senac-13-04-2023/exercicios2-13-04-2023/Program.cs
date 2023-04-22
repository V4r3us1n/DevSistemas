using System;

namespace exercicios2_13_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicitar número para tabuada

            Console.WriteLine("Digite um número... ");
            int numero1 = Int32.Parse(Console.ReadLine());

            for (int contador = 1; contador <= 10; contador++) {
                Console.WriteLine($"{numero1} x {contador} = {numero1 * contador}");
            }

            Console.WriteLine("FIM DA TABUADA!");
        }
    }
}
