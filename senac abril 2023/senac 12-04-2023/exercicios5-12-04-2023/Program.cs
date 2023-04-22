using System;

namespace exercicios5_12_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exibir Menu com 10 Opções

            int pedido;
            string nome_pedido = "";

            Console.WriteLine("BEM VINDO À NOSSA PADARIA PREZADO CLIENTE!");
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

            //Verificando Opção Escolhida...
            switch (pedido)
            {
                case 1:
                    nome_pedido = "Pizza";                    
                    break;
                case 2:
                    nome_pedido = "Hambúrguer";
                    break;
                case 3:
                    nome_pedido = "Cauzone";
                    break;
                case 4:
                    nome_pedido = "Taco";
                    break;
                case 5:
                    nome_pedido = "Nacho";
                    break;
                case 6:
                    nome_pedido = "Donut";
                    break;
                case 7:
                    nome_pedido = "Sorvete";
                    break;
                case 8:
                    nome_pedido = "Sanduíche do Hero";
                    break;
                case 9:
                    nome_pedido = "João Laranaja";
                    break;
                case 10:
                    nome_pedido = "Maçã";
                    break;
            }


            //Imprimindo Resultado
            Console.WriteLine($"Você escolheu o pedido nº {pedido}, ou seja, um(a) {nome_pedido}!");
        }
    }
}
