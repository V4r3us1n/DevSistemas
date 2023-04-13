using System;

namespace projeto3_12_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            // :^D


            /*
            //IF / ELSE
            double saldo = 1000;

            Console.WriteLine($"Você tem R${saldo} na sua conta!");

            Console.Write("Informe o valor do Saque... R$");

            double valorSaque = double.Parse(Console.ReadLine());

            if (valorSaque <= saldo)
            {
                Console.WriteLine("Saque realizado com sucesso!");
                saldo -= valorSaque;
                Console.WriteLine($"Seu saldo atual é de R${saldo}!");
            }
            else
            {
                Console.WriteLine("Você não possui dinheiro suficiente para sacar essa quantia em dinheiro!");
            }
            */

            //SWITCH CASE

            int x = 5;

            switch(x)
            {
                case 1:
                    Console.WriteLine("'x' é igual a 1!");
                    break;
                case 2:
                    Console.WriteLine("'x' é igual a 2!");
                    break;
                case 3:
                    Console.WriteLine("'x' é igual a 3!");
                    break;
                case 4:
                    Console.WriteLine("'x' é igual a 4!");
                    break;
                default:
                    Console.WriteLine("'x' é diferente de 1, 2, 3 e 4!");
                    break;
            }
        }
    }
}
