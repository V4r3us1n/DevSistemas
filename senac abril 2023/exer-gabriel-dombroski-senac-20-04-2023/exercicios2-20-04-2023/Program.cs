using System;

namespace exercicios2_20_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {

            string continuarAposentadoria = "";

            //Solicitando Informações dos Trabalhadores: Nome, Idade e Tempo de Contribuição

            string[,] trabalhadorAp = new string[1, 4];

            Console.WriteLine("==============================================");

            int i = 0;

            do {
                Console.WriteLine("");
                Console.WriteLine($"TRABALHADOR Nº{i + 1}");

                Console.Write("Informe o Nome do Trabalhador: ");
                trabalhadorAp[i, 0] = Console.ReadLine();

                Console.Write("Informe a Idade do Trabalhador: ");
                trabalhadorAp[i, 1] = Console.ReadLine();
                while (Int32.Parse(trabalhadorAp[i, 1]) < 14)
                {
                    Console.WriteLine("[ERRO!] Por favor Insira uma Idade Válida!");
                    Console.Write("Informe a Idade do Trabalhador: ");
                    trabalhadorAp[i, 1] = Console.ReadLine();
                }

                Console.Write("Informe o Tempo de Contribuição do Trabalhador: ");
                trabalhadorAp[i, 2] = Console.ReadLine();
                while (Int32.Parse(trabalhadorAp[i, 2]) > Int32.Parse(trabalhadorAp[i, 1]) - 10)
                {
                    Console.WriteLine("[ERRO!] Por favor insira um período de tempo aceitável!");
                    Console.Write("Informe o Tempo de Contribuição do Trabalhador: ");
                    trabalhadorAp[i, 2] = Console.ReadLine();
                }

                Console.WriteLine("");
                Console.WriteLine("==============================================");

                Console.Write("Deseja Continuar?");
                continuarAposentadoria = Console.ReadLine();

                if (continuarAposentadoria.ToLower() == "sim")
                {
                    string[,] arrayTemp = new string[i + 2, 4];

                    for (int j = 0; j <= i; j++)
                    {
                        arrayTemp[j, 0] = trabalhadorAp[j, 0];
                        arrayTemp[j, 1] = trabalhadorAp[j, 1];
                        arrayTemp[j, 2] = trabalhadorAp[j, 2];
                        arrayTemp[j, 3] = trabalhadorAp[j, 3];
                    }

                    trabalhadorAp = arrayTemp;

                    i++;
                }

            } while (continuarAposentadoria.ToLower() == "sim");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            //Vai conseguir se Aposentar?


            for (int j = 0; j <= i; j++) {

                if (Byte.Parse(trabalhadorAp[j, 1]) >= 65)
                {
                    trabalhadorAp[j, 3] = "Sim";
                }
                else if (Byte.Parse(trabalhadorAp[j, 2]) >= 35)
                {
                    trabalhadorAp[j, 3] = "Sim";
                }
                else if (Byte.Parse(trabalhadorAp[j, 1]) >= 60 && Byte.Parse(trabalhadorAp[j, 2]) >= 25)
                {
                    trabalhadorAp[j, 3] = "Sim";
                }
                else
                {
                    trabalhadorAp[j, 3] = "Não";
                }
            }

            //Imprimindo Resultado...

            int maiorNome = 4, maiorCont = 5, maiorIdade = 5, nEspacos1, nEspacos2, nEspacos3;

            Console.WriteLine("TABELA APOSENTADORIA:");

            for (int j = 0; j <= i; j++) {
                if (maiorNome < trabalhadorAp[j, 0].Length)
                {
                    maiorNome = trabalhadorAp[j, 0].Length;
                }
                if (maiorIdade < $"{trabalhadorAp[j, 1]} anos".Length)
                {
                    maiorIdade = $"{trabalhadorAp[j, 1]} anos".Length;
                }
                if (maiorCont < $"{trabalhadorAp[j, 2]} anos".Length)
                {
                    maiorCont = $"{trabalhadorAp[j, 2]} anos".Length;
                }
            }

            for (int j = 0; j <= i; j++) {
                nEspacos1 = 5;
                nEspacos2 = 5;
                nEspacos3 = 5;

                if (j == 0)
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
                if (trabalhadorAp[j, 0].Length < maiorNome)
                {
                    nEspacos1 = (maiorNome - trabalhadorAp[j, 0].Length) + 5;
                }
                Console.Write($"{trabalhadorAp[j, 0]}");
                for (int c = 0; c < nEspacos1; c ++) {
                    Console.Write(" ");
                }

                //Alinhando as Idades
                if ($"{trabalhadorAp[j, 1]} anos".Length < maiorIdade)
                {
                    nEspacos2 = (maiorIdade - $"{trabalhadorAp[j, 1]} anos".Length) + 5;
                }
                Console.Write($"{trabalhadorAp[j, 1]} anos");
                for (int c = 0; c < nEspacos2; c++) {
                    Console.Write(" ");
                }

                //Alinhando o Tempo de Contribuição
                if ($"{trabalhadorAp[j, 2]} anos".Length < maiorCont)
                {
                    nEspacos3 = (maiorCont - $"{trabalhadorAp[j, 2]} anos".Length) + 5;
                }
                Console.Write($"{trabalhadorAp[j, 2]} anos");
                for (int c = 0; c < nEspacos3; c++) {
                    Console.Write(" ");
                }

                //Está Aposentado?

                Console.WriteLine($"{trabalhadorAp[j, 3]}     ");
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
