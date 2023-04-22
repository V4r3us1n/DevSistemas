using System;

namespace exercicios4_20_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Informe a Quantidade de Contatos a Serem Inseridos

            int nContatos;

            Console.Write("Informe quantos contatos deseja adicionar: ");
            nContatos = Int32.Parse(Console.ReadLine());

            //Difinindo Tamanho da Matriz

            string[,] agenda = new string[nContatos, 3];

            //Solicitando informações sobre os Contatos...

            Console.WriteLine("=============================");

            int verificador, verificador2 = 0;

            for (int i = 0; i < nContatos; i ++) {
                verificador = 0;
                Console.WriteLine("");
                Console.WriteLine($"CONTATO Nº{i + 1}:");
                Console.WriteLine("");

                Console.Write("Informe o Nome do Contato: ");
                agenda[i, 0] = Console.ReadLine();

                Console.Write("Informe o Telefone do Contato [(xx)xxxxx-xxxx]: ");
                agenda[i, 1] = Console.ReadLine();

                while (verificador2 == 0)
                {
                    while (agenda[i, 1].Length != 14)
                    {
                        Console.WriteLine("[ERRO!] Por favor use a formatação recomendada: (xx)xxxxx-xxxx");
                        Console.Write("Informe o Telefone do Contato [(xx)xxxxx-xxxx]: ");
                        agenda[i, 1] = Console.ReadLine();
                    }

                    verificador = 0;

                    for (int c = 0; c < agenda[i, 1].Length; c++) {
                        if (c == 0)
                        {
                            if ($"{agenda[i, 1][c]}" != "(")
                            {
                                verificador++;
                                Console.WriteLine("Erro do Tipo 1");
                            }
                        }
                        else if (c == 3)
                        {
                            if ($"{agenda[i, 1][c]}" != ")")
                            {
                                verificador++;
                                Console.WriteLine("Erro do Tipo 1");
                            }
                        }
                        else if (c == 9)
                        {
                            if ($"{agenda[i, 1][c]}" != "-")
                            {
                                verificador++;
                                Console.WriteLine("Erro do Tipo 2");
                            }
                        }
                        else
                        {
                            if ($"{agenda[i, 1][c]}" != "0" && $"{agenda[i, 1][c]}" != "1" && $"{agenda[i, 1][c]}" != "2" && $"{agenda[i, 1][c]}" != "3" && $"{agenda[i, 1][c]}" != "4" && $"{agenda[i, 1][c]}" != "5" && $"{agenda[i, 1][c]}" != "6" && $"{agenda[i, 1][c]}" != "7" && $"{agenda[i, 1][c]}" != "8" && $"{agenda[i, 1][c]}" != "9")
                            {
                                verificador++;
                                Console.WriteLine("Erro do Tipo 3");
                            }
                        }
                    }
                    if (verificador > 0)
                    {
                        Console.WriteLine("[ERRO!] Por favor use a formatação recomendada: (xx)xxxxx-xxxx");
                        Console.Write("Informe o Telefone do Contato [(xx)xxxxx-xxxx]: ");
                        agenda[i, 1] = Console.ReadLine();
                    }
                    else
                    {
                        verificador2 = 1;
                    }
                }

                Console.Write("Informe o Endereço do Contato: ");
                agenda[i, 2] = Console.ReadLine();

                Console.WriteLine("");
                Console.WriteLine("=============================");
            }

            Console.WriteLine("");
            Console.WriteLine("");

            //IMPRIMINDO AGENDA

            Console.WriteLine("SUA AGENDA:");

            Console.WriteLine("=============================");
            for (int i = 0; i < nContatos; i++) {
                Console.WriteLine($"Contato Nº{i + 1}:");
                Console.WriteLine("");
                Console.WriteLine($"Nome: {agenda[i, 0]}");
                Console.WriteLine($"Telefone: {agenda[i, 1]}");
                Console.WriteLine($"Endereço: {agenda[i, 2]}");
                Console.WriteLine("");
                Console.WriteLine("=============================");
            }

        }
    }
}
