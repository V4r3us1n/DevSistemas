using System;

namespace exercicio2_26_04_2023
{
    class Program
    {
        static string[] Tabela;
        static int maiorNome = 4, maiorCont = 5, maiorIdade = 5, nEspacos1, nEspacos2, nEspacos3;

        static void Main(string[] args)
        {
            int nTrabalhadores;
            Console.Write("Informe a Quantos Trabalhos Desejam Pedir sua Aposentadoria: ");
            nTrabalhadores = Int32.Parse(Console.ReadLine());

            string[] nome = new string[nTrabalhadores];
            int[] idade = new int[nTrabalhadores];
            int[] tempoServico = new int[nTrabalhadores];
            string[] situacaoAposentadoria = new string[nTrabalhadores];

            Console.WriteLine("");

            for (int i = 0; i < nTrabalhadores; i++)
            {
                Console.WriteLine("===============================================");
                Console.WriteLine("");
                Console.Write($"Informe o Nome do {i+1}º Trabalhador: ");
                nome[i] = Console.ReadLine();

                Console.Write("Informe a Idade do Trabalhador: ");
                idade[i] = Int32.Parse(Console.ReadLine());

                Console.Write("Informe o Tempo de Contribuição do Trabalhador: ");
                tempoServico[i] = Int32.Parse(Console.ReadLine());

            }

            //Validando Aposentadoria

            ValidarAposentadoria(idade, tempoServico, ref situacaoAposentadoria);
            VerificandoMaior(nome, idade, tempoServico, ref maiorNome, ref maiorIdade, ref maiorCont);

            //Criando Tabela

            GerarTabelaAposentadoria(nome, idade, tempoServico, situacaoAposentadoria);

            //Imprimindo Tabela

            Console.WriteLine("");

            for (int j = 0; j < Tabela.Length; j++)
            {
                Console.WriteLine(Tabela[j]);
            }

        }

        static void ValidarAposentadoria (int[] array1, int[] array2, ref string[] array3)
        {
            for (int j = 0; j < array1.Length; j++)
            {
                if (array1[j] >= 65)
                {
                    array3[j] = "Sim";
                }
                else if (array2[j] >= 35)
                {
                    array3[j] = "Sim";
                }
                else if (array1[j] >= 60 && array2[j] >= 25)
                {
                    array3[j] = "Sim";
                }
                else
                {
                    array3[j] = "Não";
                }
            }
        }


        static void VerificandoMaior(string[] array1, int[] array2, int[] array3, ref int maiorNome, ref int maiorIdade, ref int maiorCont)
        {
            for (int i = 0; i < array1.Length; i++) {
                if (maiorNome < array1[i].Length)
                {
                    maiorNome = array1[i].Length;
                }
                if (maiorIdade < $"{array2[i]} anos".Length)
                {
                    maiorIdade = $"{array2[i]} anos".Length;
                }
                if (maiorCont < $"{array3[i]} anos".Length)
                {
                    maiorCont = $"{array3[i]} anos".Length;
                }
            }
        }
        static void GerarTabelaAposentadoria(string[] array1, int[] array2, int[] array3, string[] array4)
        {
            Tabela = new string[array1.Length + 5];

            int j = 0;


            Console.WriteLine("TABELA APOSENTADORIA:");
            
            for (int i = 0; i < array1.Length; i++) {
                nEspacos1 = 5;
                nEspacos2 = 5;
                nEspacos3 = 5;

                if (i == 0)
                {
                    for (int c = 0; c < (maiorCont + maiorIdade + maiorNome + "situacao".Length) + 15; c++) {
                        Tabela[j] += "=";
                    }
                    j++;

                    //Primeira Linha da Tabela

                    Tabela[j] = "Nome";
                    for (int c = 0; c < (maiorNome - "nome".Length) + 5; c++) {
                        Tabela[j] += " ";
                    }

                    Tabela[j] += "Idade";
                    for (int c = 0; c < (maiorIdade - "idade".Length) + 5; c++) {
                        Tabela[j] += " ";
                    }

                    Tabela[j] += "Tempo";
                    for (int c = 0; c < (maiorCont - "tempo".Length) + 5; c++) {
                        Tabela[j] += " ";
                    }

                    Tabela[j] += "Situação";

                    j++;

                    //Segundo Linha da Tabala

                    for (int c = 0; c < maiorNome; c++) {
                        Tabela[j] += "=";
                    }
                    for (int c = 0; c < 5; c++) {
                        Tabela[j] += " ";
                    }

                    for (int c = 0; c < maiorIdade; c++) {
                        Tabela[j] += "=";
                    }
                    for (int c = 0; c < 5; c++) {
                        Tabela[j] += " ";
                    }

                    for (int c = 0; c < maiorCont; c++) {
                        Tabela[j] += "=";
                    }
                    for (int c = 0; c < 5; c++) {
                        Tabela[j] += " ";
                    }

                    for (int c = 0; c < "situacao".Length; c++) {
                        if (c == "situacao".Length - 1)
                        {
                            Tabela[j] += "=";
                        }
                        else
                        {
                            Tabela[j] += "=";
                        }
                    }
                    j++;
                }

                //Alinhando os Nomes
                if (array1[i].Length < maiorNome)
                {
                    nEspacos1 = (maiorNome - array1[i].Length) + 5;
                }
                Tabela[j] += $"{array1[i]}";
                for (int c = 0; c < nEspacos1; c ++) {
                    Tabela[j] += " ";
                }

                //Alinhando as Idades
                if ($"{array2[i]} anos".Length < maiorIdade)
                {
                    nEspacos2 = (maiorIdade - $"{array2[i]} anos".Length) + 5;
                }
                Tabela[j] += $"{array2[i]} anos";
                for (int c = 0; c < nEspacos2; c++) {
                    Tabela[j] += " ";
                }

                //Alinhando o Tempo de Contribuição
                if ($"{array3[i]} anos".Length < maiorCont)
                {
                    nEspacos3 = (maiorCont - $"{array3[i]} anos".Length) + 5;
                }
                Tabela[j] += $"{array3[i]} anos";
                for (int c = 0; c < nEspacos3; c++) {
                    Tabela[j] += " ";
                }

                //Está Aposentado?

                Tabela[j] += $"{array4[i]}     ";

                j++;
            }
        
            Tabela[j] += "";

            j++;

            for (int c = 0; c < (maiorCont + maiorIdade + maiorNome + "situacao".Length) + 15; c++) {
                Tabela[j] += "=";
            }
        }
    }
}
