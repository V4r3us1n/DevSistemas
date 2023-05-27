using System;

namespace exercicio1_18_05_2023
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
                
                //Solicitando Nome do ANimal
                Console.Write("Nome do Animal: ");
                string nomeAnimal = Console.ReadLine();

                //Solicitando Nome do Dono do Animal
                Console.Write("Dono do Animal: ");
                string donoAnimal = Console.ReadLine();

                int nCategoriaAnimal = 0;
                string[] nomeCategoriaAnimal = new string [4];
                nomeCategoriaAnimal[0] = "Cachorro";
                nomeCategoriaAnimal[1] = "Gato";
                nomeCategoriaAnimal[2] = "Vaca";
                nomeCategoriaAnimal[3] = "Cavalo";

                //Solicitando Categoria do Animal
                do {
                    Console.WriteLine("[1] Cachorro, [2] Gato, [3] Vaca, [4] Cavalo, [5] Peixe");
                    Console.Write("Digite a Categoria do seu Animal: ");
                    nCategoriaAnimal = Int32.Parse(Console.ReadLine());

                    if (nCategoriaAnimal < 1 || nCategoriaAnimal > 5)
                    {
                        Console.WriteLine("[ERRO!] CATEGORIA INVÁLIDA!");
                    }
                } while (nCategoriaAnimal < 1 || nCategoriaAnimal > 5);

                Relatorio relatorio = new Relatorio();
                Console.WriteLine("");
                string respostaAndando = "";

                switch (nCategoriaAnimal)
                {
                    case 1:

                        do {
                            Console.WriteLine("O animal está andando? [S/N]");
                            respostaAndando = Console.ReadLine();
                            
                            if (respostaAndando.ToUpper() != "S" && respostaAndando.ToUpper() != "N")
                            {
                                Console.WriteLine("[ERRO!] RESPOSTA INVÁLIDA!");
                                Console.WriteLine("");
                            }
                        } while (respostaAndando.ToUpper() != "S" && respostaAndando.ToUpper() != "N");

                        Console.WriteLine("");

                        Cachorro cachorro = new Cachorro(nomeAnimal, donoAnimal);
                        relatorio.ExibirRelatorio(cachorro);
                        Console.WriteLine($"Andando? {cachorro.Caminhando(respostaAndando)}");
                        Console.WriteLine("");
                        Console.WriteLine("=====================================================");

                        break;
                    case 2:
                        do {
                            Console.WriteLine("O animal está andando? [S/N]");
                            respostaAndando = Console.ReadLine();
                            
                            if (respostaAndando.ToUpper() != "S" && respostaAndando.ToUpper() != "N")
                            {
                                Console.WriteLine("[ERRO!] RESPOSTA INVÁLIDA!");
                                Console.WriteLine("");
                            }
                        } while (respostaAndando.ToUpper() != "S" && respostaAndando.ToUpper() != "N");

                        Console.WriteLine("");

                        Gato gato = new Gato(nomeAnimal, donoAnimal);

                        relatorio.ExibirRelatorio(gato);
                        Console.WriteLine($"Andando? {gato.Caminhando(respostaAndando)}");
                        Console.WriteLine("");
                        Console.WriteLine("=====================================================");

                        break;
                    case 3:
                        do {
                            Console.WriteLine("O animal está andando? [S/N]");
                            respostaAndando = Console.ReadLine();
                            
                            if (respostaAndando.ToUpper() != "S" && respostaAndando.ToUpper() != "N")
                            {
                                Console.WriteLine("[ERRO!] RESPOSTA INVÁLIDA!");
                                Console.WriteLine("");
                            }
                        } while (respostaAndando.ToUpper() != "S" && respostaAndando.ToUpper() != "N");

                        Console.WriteLine("");

                        Vaca vaca = new Vaca(nomeAnimal, donoAnimal);

                        relatorio.ExibirRelatorio(vaca);
                        Console.WriteLine($"Andando? {vaca.Caminhando(respostaAndando)}");
                        Console.WriteLine("");
                        Console.WriteLine("=====================================================");

                        break;
                    case 4:
                        do {
                            Console.WriteLine("O animal está andando? [S/N]");
                            respostaAndando = Console.ReadLine();
                            
                            if (respostaAndando.ToUpper() != "S" && respostaAndando.ToUpper() != "N")
                            {
                                Console.WriteLine("[ERRO!] RESPOSTA INVÁLIDA!");
                                Console.WriteLine("");
                            }
                        } while (respostaAndando.ToUpper() != "S" && respostaAndando.ToUpper() != "N");

                        Console.WriteLine("");

                        Cavalo cavalo = new Cavalo(nomeAnimal, donoAnimal);

                        relatorio.ExibirRelatorio(cavalo);
                        Console.WriteLine($"Andando? {cavalo.Caminhando(respostaAndando)}");
                        Console.WriteLine("");
                        Console.WriteLine("=====================================================");

                        break;
                    case 5:
                        Peixe peixe = new Peixe(nomeAnimal, donoAnimal);

                        relatorio.ExibirRelatorio(peixe);
                        Console.WriteLine("");
                        Console.WriteLine("=====================================================");

                        break;
                }

                //Perguntando se o Usuário Deseja Continuar o Loop
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
