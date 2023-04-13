using System;

namespace exercicios4_12_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exibir Menu com 10 Opções

            int pedido;
            string nome_pedido;

            Console.WriteLine("BEM VINDO À NOSSA PADARIA PREZADO CLIENTE!");
            Console.WriteLine("Por favor escolha uma das opções a seguir para seu pedido...");
            Console.WriteLine("[1] Pizza");
            Console.WriteLine("[2] Hambúrguer");
            Console.WriteLine("[3] Cauzone");
            Console.WriteLine("[4] Tacos");
            Console.WriteLine("[5] Nachos");
            Console.WriteLine("[6] Donuts");
            Console.WriteLine("[7] Sorvete");
            Console.WriteLine("[8] Sanduíche do Hero");
            Console.WriteLine("[9] João Laranja");
            Console.WriteLine("[10] Maçã");

            Console.Write("Digite aqui o seu pedido... ");
            pedido = Int32.Parse(Console.ReadLine());
            

            //Validando resposta

            while (pedido > 10 || pedido < 1)
            {
                Console.WriteLine("[ERRO!] Por favor escolha uma das opções disponíveis!");
                Console.WriteLine("Por favor escolha uma das opções a seguir para seu pedido...");
                Console.WriteLine("[1] Pizza");
                Console.WriteLine("[2] Hambúrguer");
                Console.WriteLine("[3] Cauzone");
                Console.WriteLine("[4] Taco");
                Console.WriteLine("[5] Nacho");
                Console.WriteLine("[6] Donut");
                Console.WriteLine("[7] Sorvete");
                Console.WriteLine("[8] Sanduíche do Hero");
                Console.WriteLine("[9] João Laranja");
                Console.WriteLine("[10] Maçã");

                Console.Write("Digite aqui o seu pedido... ");
                pedido = Int32.Parse(Console.ReadLine());
            }

            //Verificando Opção Escolhida

            if (pedido == 1)
            {
                nome_pedido = "Pizza";
            }
            else if (pedido == 2)
            {
                nome_pedido = "Hambúrguer";
            }
            else if (pedido == 3)
            {
                nome_pedido = "Cauzone";
            }
            else if (pedido == 4)
            {
                nome_pedido = "Taco";
            }
            else if (pedido == 5)
            {
                nome_pedido = "Nacho";
            }
            else if (pedido == 6)
            {
                nome_pedido = "Donut";
            }
            else if (pedido == 7)
            {
                nome_pedido = "Sorvete";
            }
            else if (pedido == 8)
            {
                nome_pedido = "Sanduíche do Hero";
            }
            else if (pedido == 9)
            {
                nome_pedido = "João Laranja";
            }
            else
            {
                nome_pedido = "Maçã";
            }


            //Imprimindo resultado
            Console.WriteLine($"Você escolheu o pedido nº {pedido}, ou seja, um(a) {nome_pedido}!");
        }
    }
}
