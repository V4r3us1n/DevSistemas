using System;

namespace exercicios18_13_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicitar o nome de uma pessoa

            string nome, continuarNome;

            Console.Write("Digite o nome de alguém... ");
            nome = Console.ReadLine();

            Console.WriteLine("Gostaria de Digitar mais um Nome? [S/N]");
            continuarNome = Console.ReadLine();

            while (continuarNome != "s" && continuarNome != "S" && continuarNome != "n" && continuarNome != "N")
            {
                Console.WriteLine("[ERRO!] Por favor digite 'S' ou 'N' de acordo com sua preferência!");

                Console.WriteLine("Gostaria de Digitar mais um Nome? [S/N]");
                continuarNome = Console.ReadLine();
            }

            while (continuarNome == "s" || continuarNome == "S")
            {
                Console.Write("Digite o nome de alguém... ");
                nome = Console.ReadLine();

                Console.WriteLine("Gostaria de Digitar mais um Nome? [S/N]");
                continuarNome = Console.ReadLine();

                while (continuarNome != "s" && continuarNome != "S" && continuarNome != "n" && continuarNome != "N")
                {
                    Console.WriteLine("[ERRO!] Por favor digite 'S' ou 'N' de acordo com sua preferência!");

                    Console.WriteLine("Gostaria de Digitar mais um Nome? [S/N]");
                    continuarNome = Console.ReadLine();
                }
            }
            Console.WriteLine("FIM DO PROGRAMA!");

        }
    }
}
