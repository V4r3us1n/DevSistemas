using System;

namespace exercicios20_13_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicitar número ao usuário
            int valor1, contador = 1;

            Console.Write("Digite um número... ");
            valor1 = Int32.Parse(Console.ReadLine());

            //Imprimindo Tabuada

            do {
                Console.WriteLine($"{valor1} x {contador} = {valor1 * contador}");
                contador++;
            } while (contador <= 10);

            Console.WriteLine("FIM DO PROGRAMA!");
        }
    }
}
