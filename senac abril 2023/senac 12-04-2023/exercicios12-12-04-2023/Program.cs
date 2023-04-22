using System;

namespace exercicios12_12_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exibindo o Menu

            byte opcaoConversao;
            double temperatura, conversaoTemperatura;

            Console.WriteLine("Bem-vindo! O que você gostaria de converter Hoje?");
            Console.WriteLine("[1] Celsius para Farenheit");
            Console.WriteLine("[2] Celsius para Kelvin");
            Console.WriteLine("[3] Farenheit para Celsius");
            Console.WriteLine("[4] Farenheit para Kelvin");
            Console.WriteLine("[5] Kelvin para Celsius");
            Console.WriteLine("[6] Kelvin para Farenheit");

            Console.Write("Digite aqui a opção desejada... ");
            opcaoConversao = Byte.Parse(Console.ReadLine());

            //Validando resposta...

            while (opcaoConversao < 1 || opcaoConversao > 6)
            {
                Console.WriteLine("[ERRO!] Por favor escolha uma das opções mencionadas!");

                Console.WriteLine("Bem-vindo! O que você gostaria de converter Hoje?");
                Console.WriteLine("[1] Celsius para Farenheit");
                Console.WriteLine("[2] Celsius para Kelvin");
                Console.WriteLine("[3] Farenheit para Celsius");
                Console.WriteLine("[4] Farenheit para Kelvin");
                Console.WriteLine("[5] Kelvin para Celsius");
                Console.WriteLine("[6] Kelvin para Farenheit");

                Console.Write("Digite aqui a opção desejada... ");
                opcaoConversao = Byte.Parse(Console.ReadLine());
            }

            //Solicitando Valor de Temperatura...

            switch (opcaoConversao)
            {
                case 1:
                    Console.Write("Informe a Temperatura em Celsius... ");
                    temperatura = Double.Parse(Console.ReadLine());

                    conversaoTemperatura = (temperatura * 1.8) + 32;

                    Console.WriteLine($"Convertendo {temperatura}ºC para Farenheit fica {conversaoTemperatura}F!");
                    break;
                case 2:
                    Console.Write("Informe a Temperatura em Celsius... ");
                    temperatura = Double.Parse(Console.ReadLine());

                    conversaoTemperatura = temperatura + 273;

                    Console.WriteLine($"Convertendo {temperatura}ºC para Kelvin fica {conversaoTemperatura}K!");
                    break;
                case 3:
                    Console.Write("Informe a Temperatura em Farenheit... ");
                    temperatura = Double.Parse(Console.ReadLine());

                    conversaoTemperatura = (temperatura - 32) * 1.8;

                    Console.WriteLine($"Convertendo {temperatura}F para Celsius fica {conversaoTemperatura}ºC!");
                    break;
                case 4:
                    Console.Write("Informe a Temperatura em Farenheit... ");
                    temperatura = Double.Parse(Console.ReadLine());

                    conversaoTemperatura = (temperatura - 32) * 5 / 9 + 273;

                    Console.WriteLine($"Convertendo {temperatura}F para Kelvin fica {conversaoTemperatura}K!");
                    break;
                case 5:
                    Console.Write("Informe a Temperatura em Kelvin... ");
                    temperatura = Double.Parse(Console.ReadLine());

                    conversaoTemperatura = temperatura - 273;

                    Console.WriteLine($"Convertendo {temperatura}K para Celsius fica {conversaoTemperatura}ºC!");
                    break;
                case 6:
                    Console.Write("Informe a Temperatura em Kelvin... ");
                    temperatura = Double.Parse(Console.ReadLine());

                    conversaoTemperatura = (temperatura - 273) * 1.8 + 32;

                    Console.WriteLine($"Convertendo {temperatura}K para Farenheit fica {conversaoTemperatura}F!");
                    break;
            }
        }
    }
}
