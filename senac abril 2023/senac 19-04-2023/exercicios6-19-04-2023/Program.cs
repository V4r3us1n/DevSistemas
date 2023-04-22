using System;

namespace exercicios6_19_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicitar Nº de Trabalhadoires que vão pedir aposentadoria

            int nTrabalhadoresAp;

            Console.Write("Digite a quantidade de Trabalhadores que desejam Solicitar Aposentadoria: ");
            nTrabalhadoresAp = Int32.Parse(Console.ReadLine());

            //Solicitando Informações dos Trabalhadores: Nome, Idade e Tempo de Contribuição

            string[] nomeTrabalhador = new string[nTrabalhadoresAp];
            byte[] idadeTrabalhador = new byte[nTrabalhadoresAp];
            byte[] tempoConTb = new byte[nTrabalhadoresAp];
            string[] situacaoAposentadoria = new string[nTrabalhadoresAp];

            Console.WriteLine("==============================================");

            for (int i = 0; i < nTrabalhadoresAp; i++) {
                Console.WriteLine("");
                Console.WriteLine($"TRABALHADOR Nº{i + 1}");

                Console.Write("Informe o Nome do Trabalhador: ");
                nomeTrabalhador[i] = Console.ReadLine();

                Console.Write("Informe a Idade do Trabalhador: ");
                idadeTrabalhador[i] = Byte.Parse(Console.ReadLine());
                while (idadeTrabalhador[i] < 14)
                {
                    Console.WriteLine("[ERRO!] Por favor insira uma Idade Válida!");
                    Console.Write("Informe a Idade do Trabalhador: ");
                    idadeTrabalhador[i] = Byte.Parse(Console.ReadLine());
                }

                Console.Write("Informe o Tempo de Contribuição do Trabalhador: ");
                tempoConTb[i] = Byte.Parse(Console.ReadLine());

                while (tempoConTb[i] > idadeTrabalhador[i] - 10)
                {
                    Console.WriteLine("[ERRO!] Por favor insira um período de tempo aceitável!");
                    Console.Write("Informe o Tempo de Contribuição do Trabalhador: ");
                    tempoConTb[i] = Byte.Parse(Console.ReadLine());
                }

                Console.WriteLine("");
                Console.WriteLine("==============================================");
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            //Vai conseguir se Aposentar?

            for (int i = 0; i < nTrabalhadoresAp; i++) {

                if (idadeTrabalhador[i] >= 65)
                {
                    situacaoAposentadoria[i] = "Sim";
                }
                else if (tempoConTb[i] >= 35)
                {
                    situacaoAposentadoria[i] = "Sim";
                }
                else if (idadeTrabalhador[i] >= 60 && tempoConTb[i] >= 25)
                {
                    situacaoAposentadoria[i] = "Sim";
                }
                else
                {
                    situacaoAposentadoria[i] = "Não";
                }
            }

            //Imprimindo Resultado...

            int maiorNome = 4, maiorCont = 5, maiorIdade = 5, nEspacos1, nEspacos2, nEspacos3;

            Console.WriteLine("TABELA APOSENTADORIA:");

            for (int i = 0; i < nTrabalhadoresAp; i++) {
                if (maiorNome < nomeTrabalhador[i].Length)
                {
                    maiorNome = nomeTrabalhador[i].Length;
                }
                if (maiorIdade < $"{idadeTrabalhador[i]} anos".Length)
                {
                    maiorIdade = $"{idadeTrabalhador[i]} anos".Length;
                }
                if (maiorCont < $"{tempoConTb[i]} anos".Length)
                {
                    maiorCont = $"{tempoConTb[i]} anos".Length;
                }
            }

            for (int i = 0; i < nTrabalhadoresAp; i++) {
                nEspacos1 = 5;
                nEspacos2 = 5;
                nEspacos3 = 5;

                if (i == 0)
                {
                    for (int c = 0; c < (maiorCont + maiorIdade + maiorNome + "situacao".Length) + 15; c++) {
                        if (c == (maiorCont + maiorIdade + maiorNome + "situacao".Length + 15) - 1)
                        {
                            Console.WriteLine("=");
                        }
                        else
                        {
                            Console.Write("=");
                        }
                    }

                    Console.WriteLine("");

                    //Primeira Linha da Tabela

                    Console.Write("Nome");
                    for (int c = 0; c < (maiorNome - "nome".Length) + 5; c++) {
                        Console.Write(" ");
                    }

                    Console.Write("Idade");
                    for (int c = 0; c < (maiorIdade - "idade".Length) + 5; c++) {
                        Console.Write(" ");
                    }

                    Console.Write("Tempo");
                    for (int c = 0; c < (maiorCont - "tempo".Length) + 5; c++) {
                        Console.Write(" ");
                    }

                    Console.WriteLine("Situação");

                    //Segundo Linha da Tabala

                    for (int c = 0; c < maiorNome; c++) {
                        Console.Write("=");
                    }
                    for (int c = 0; c < 5; c++) {
                        Console.Write(" ");
                    }

                    for (int c = 0; c < maiorIdade; c++) {
                        Console.Write("=");
                    }
                    for (int c = 0; c < 5; c++) {
                        Console.Write(" ");
                    }

                    for (int c = 0; c < maiorCont; c++) {
                        Console.Write("=");
                    }
                    for (int c = 0; c < 5; c++) {
                        Console.Write(" ");
                    }

                    for (int c = 0; c < "situacao".Length; c++) {
                        if (c == "situacao".Length - 1)
                        {
                            Console.WriteLine("=");
                        }
                        else
                        {
                            Console.Write("=");
                        }
                    }
                }

                //Alinhando os Nomes
                if (nomeTrabalhador[i].Length < maiorNome)
                {
                    nEspacos1 = (maiorNome - nomeTrabalhador[i].Length) + 5;
                }
                Console.Write($"{nomeTrabalhador[i]}");
                for (int c = 0; c < nEspacos1; c ++) {
                    Console.Write(" ");
                }

                //Alinhando as Idades
                if ($"{idadeTrabalhador[i]} anos".Length < maiorIdade)
                {
                    nEspacos2 = (maiorIdade - $"{idadeTrabalhador[i]} anos".Length) + 5;
                }
                Console.Write($"{idadeTrabalhador[i]} anos");
                for (int c = 0; c < nEspacos2; c++) {
                    Console.Write(" ");
                }

                //Alinhando o Tempo de Contribuição
                if ($"{tempoConTb[i]} anos".Length < maiorCont)
                {
                    nEspacos3 = (maiorCont - $"{tempoConTb[i]} anos".Length) + 5;
                }
                Console.Write($"{tempoConTb[i]} anos");
                for (int c = 0; c < nEspacos3; c++) {
                    Console.Write(" ");
                }

                //Está Aposentado?

                Console.WriteLine($"{situacaoAposentadoria[i]}     ");
            }
        
            Console.WriteLine("");
            for (int c = 0; c < (maiorCont + maiorIdade + maiorNome + "situacao".Length) + 15; c++) {
                if (c == (maiorCont + maiorIdade + maiorNome + "situacao".Length + 15) - 1)
                {
                    Console.WriteLine("=");
                }
                else
                {
                    Console.Write("=");
                }
            }

            Console.WriteLine("");

        }
    }
}
