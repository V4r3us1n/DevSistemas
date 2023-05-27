using System;

namespace exercicio5_27_04_2023
{
    class Program
    {
        static string[] nome = new string[1];
        static string[] Tabela;
        static int[] idade = new int[1];
        static int[,] tempoServico = new int[1,3];
        static string[] situacaoAposentadoria = new string[1];
        static int maiorNome = 4, maiorCont = 5, maiorIdade = 5, nEspacos1, nEspacos2, nEspacos3;

        static void Main(string[] args)
        {

            string verificador = "";
            int i = 0;

            do {
                Console.WriteLine("===============================================");
                Console.WriteLine("");
                Console.Write("Informe o Nome do Trabalhador: ");
                nome[i] = Console.ReadLine();

                Console.Write("Informe a Idade do Trabalhador: ");
                idade[i] = Int32.Parse(Console.ReadLine());

                Console.Write("Informe a Quantidade de ANOS COMPLETOS de Contribuição do Trabalhador: ");
                tempoServico[i, 0] = Int32.Parse(Console.ReadLine());
                while (tempoServico[i,0] > idade[i] - 10 || tempoServico[i,0] < 0)
                {
                    Console.WriteLine("[ERRO!] O Tempo de Contribuição não pode ser Maior que a Idade do Trabalhador - 10!");
                    Console.WriteLine("");

                    Console.Write("Informe a Quantidade de ANOS COMPLETOS de Contribuição do Trabalhador: ");
                    tempoServico[i, 0] = Int32.Parse(Console.ReadLine());
                }

                Console.Write("Informe a Quantidade de MESES COMPLETOS correspondentes ao ANO INCOMPLETO de Contribuição do Trabalhador: ");
                tempoServico[i, 1] = Int32.Parse(Console.ReadLine());
                while (tempoServico[i,1] > 11 || tempoServico[i,1] < 0)
                {
                    Console.WriteLine("[ERRO!] Os Meses Completos Devem ser MENOR que 12!");
                    Console.WriteLine("");

                    Console.Write("Informe a Quantidade de MESES COMPLETOS correspondentes ao ANO INCOMPLETO de Contribuição do Trabalhador: ");
                    tempoServico[i, 1] = Int32.Parse(Console.ReadLine());
                }

                Console.Write("Informe a Quantidade de DIAS correspondentes ao MÊS INCOMPLETO de Contribuição do Trabalhador: ");
                tempoServico[i, 2] = Int32.Parse(Console.ReadLine());
                while (tempoServico[i,2] > 30 || tempoServico[i,2] < 0)
                {
                    Console.WriteLine("[ERRO!] Os Dias de Trabalho Devem ser MENOR que 31!");
                    Console.WriteLine("");

                    Console.Write("Informe a Quantidade de DIAS correspondentes ao MÊS INCOMPLETO de Contribuição do Trabalhador: ");
                    tempoServico[i, 2] = Int32.Parse(Console.ReadLine());
                }

                Console.Write("Deseja Continuar? ");
                verificador = Console.ReadLine();

                if (verificador.ToLower() == "sim")
                {
                    AumentarTamanhoArrayInt(ref idade);
                    AumentarTamanhoMatrizInt(ref tempoServico, i);
                    AumentarTamanhoArrayStr(ref nome);
                    AumentarTamanhoArrayStr(ref situacaoAposentadoria);

                    i++;
                }

            } while (verificador.ToLower() == "sim");

            //Validando Aposentadoria

            ValidarAposentadoria(idade, tempoServico);
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

        static void AumentarTamanhoMatrizInt(ref int[,] matriz, int i)
        {
            int[,] matrizTemp = new int[i + 2, 3];

            for (int j = 0; j <= i; j++)
            {
                matrizTemp[j,0] = matriz[j,0];
                matrizTemp[j,1] = matriz[j,1];
                matrizTemp[j,2] = matriz[j,2];
            }

            matriz = matrizTemp;
        }

        static void AumentarTamanhoArrayStr(ref string[] array)
        {
            string[] arrayTemp = new string[array.Length + 1];

            for (int j = 0; j < array.Length; j++)
            {
                arrayTemp[j] = array[j];
            }

            array = arrayTemp;
        }

        static void AumentarTamanhoArrayInt(ref int[] array)
        {
            int[] arrayTemp = new int[array.Length + 1];

            for (int j = 0; j < array.Length; j++)
            {
                arrayTemp[j] = array[j];
            }

            array = arrayTemp;
        }

        static void ValidarAposentadoria (int[] array1, int[,] array2)
        {
            for (int j = 0; j < array1.Length; j++)
            {
                if (array1[j] >= 65)
                {
                    situacaoAposentadoria[j] = "Sim";
                }
                else if (array2[j,0] >= 35)
                {
                    situacaoAposentadoria[j] = "Sim";
                }
                else if (array1[j] >= 60 && array2[j,0] >= 25)
                {
                    situacaoAposentadoria[j] = "Sim";
                }
                else
                {
                    situacaoAposentadoria[j] = "Não";
                }
            }
        }


        static void VerificandoMaior(string[] array1, int[] array2, int[,] array3, ref int maiorNome, ref int maiorIdade, ref int maiorCont)
        {
            for (int k = 0; k < array1.Length; k++) {
                if (maiorNome < array1[k].Length)
                {
                    maiorNome = array1[k].Length;
                }
                if (maiorIdade < $"{array2[k]} anos".Length)
                {
                    maiorIdade = $"{array2[k]} anos".Length;
                }
                if (maiorCont < $"{array3[k,0]} anos {array3[k,1]} meses {array3[k,2]} dias".Length)
                {
                    maiorCont = $"{array3[k,0]} anos {array3[k,1]} meses {array3[k,2]} dias".Length;
                }
            }
        }
        static void GerarTabelaAposentadoria(string[] array1, int[] array2, int[,] array3, string[] array4)
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
                if ($"{array3[i,0]} anos {array3[i,1]} meses {array3[i,2]} dias".Length < maiorCont)
                {
                    nEspacos3 = (maiorCont - $"{array3[i,0]} anos {array3[i,1]} meses {array3[i,2]} dias".Length) + 5;
                }
                Tabela[j] += $"{array3[i,0]} anos {array3[i,1]} meses {array3[i,2]} dias";
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
