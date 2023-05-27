using System;

namespace exercicio1_17_05_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //INICIALIZANDO O PROGRAMA
            bool continuarLoop = true;

            do {
                Console.WriteLine("           CADASTRANDO ANIMAL");
                Console.WriteLine("==============================================");
                
                Console.Write("Nome do Animal: ");
                string nomeAnimal = Console.ReadLine();

                Console.Write("Dono do Animal: ");
                string donoAnimal = Console.ReadLine();

                int nCategoriaAnimal = 0;
                string[] nomeCategoriaAnimal = new string [4];
                nomeCategoriaAnimal[0] = "Cachorro";
                nomeCategoriaAnimal[1] = "Gato";
                nomeCategoriaAnimal[2] = "Vaca";
                nomeCategoriaAnimal[3] = "Cavalo";


                do {
                    Console.WriteLine("[1] Cachorro, [2] Gato, [3] Vaca, [4] Cavalo");
                    Console.Write("Digite a Categoria do seu Animal: ");
                    nCategoriaAnimal = Int32.Parse(Console.ReadLine());

                    if (nCategoriaAnimal < 1 || nCategoriaAnimal > 4)
                    {
                        Console.WriteLine("[ERRO!] CATEGORIA INVÁLIDA!");
                    }
                } while (nCategoriaAnimal < 1 || nCategoriaAnimal > 4);

                Animal animal;
                Relatorio relatorio = new Relatorio();
                Console.WriteLine("");

                switch (nCategoriaAnimal)
                {
                    case 1:
                        animal = new Cachorro(nomeAnimal, donoAnimal);

                        relatorio.ExibirRelatorio(animal);

                        break;
                    case 2:
                        animal = new Gato(nomeAnimal, donoAnimal);

                        relatorio.ExibirRelatorio(animal);

                        break;
                    case 3:
                        animal = new Vaca(nomeAnimal, donoAnimal);

                        relatorio.ExibirRelatorio(animal);

                        break;
                    case 4:
                        animal = new Cavalo(nomeAnimal, donoAnimal);

                        relatorio.ExibirRelatorio(animal);

                        break;
                }

                Console.WriteLine("");
                Console.WriteLine("Deseja Continuar? [S/N]");
                string resposta = Console.ReadLine();
                Console.WriteLine("");

                if (resposta.ToUpper() == "S")
                {
                    Console.WriteLine("Ok...");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("[AVISO!] Saindo... ");
                    Console.WriteLine("");
                    continuarLoop = false;
                }

            } while (continuarLoop == true);
        }
    }
}
