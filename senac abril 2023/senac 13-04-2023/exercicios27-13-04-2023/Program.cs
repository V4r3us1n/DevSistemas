using System;

namespace exercicios27_13_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicitando Números para o Usuário, caso digite 0 o programa será encerrado

            int valor1, soma = 0;

            Console.Write("Digite um número, caso digite 0 o programa será encerrado... ");
            valor1 = Int32.Parse(Console.ReadLine());

            do {
                if(valor1 % 2 == 1)
                {
                    soma += valor1;
                }

                Console.Write("Digite um número, caso digite 0 o programa será encerrado... ");
                valor1 = Int32.Parse(Console.ReadLine());
            } while (valor1 != 0);

            Console.WriteLine($"A soma de todos os números ímpares digitados é {soma}!");
            Console.WriteLine("FIM DO PROGRAMA!");
        }
    }
}
