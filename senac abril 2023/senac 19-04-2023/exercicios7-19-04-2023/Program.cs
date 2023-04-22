using System;

namespace exercicios7_19_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicitando o Nº de Produtos

            int nProdutos;

            Console.Write("Informe a Quantidade de Produtos: ");
            nProdutos = Int32.Parse(Console.ReadLine());

            //Definindo Tamanho dos Arrays

            string[] nomeProduto = new string[nProdutos];
            double[] precoProduto = new double[nProdutos];
            int[] estokProduto = new int[nProdutos];

            //Definindo Informações Sobre Cada Produto...

            Console.WriteLine("================================");
            Console.WriteLine("");

            for (int i = 0; i < nProdutos; i++) {
                Console.WriteLine($"PRODUTO Nº{i + 1}");
                Console.WriteLine("");

                Console.Write("Informe o Nome do Produto: ");
                nomeProduto[i] = Console.ReadLine();

                Console.Write("Informe o Preço do Produto: R$");
                precoProduto[i] = Double.Parse(Console.ReadLine());
                while (precoProduto[i] < 0.01)
                {
                    Console.WriteLine("[ERRO!] Por favor  Insira um Preço Válido!");
                    Console.Write("Informe o Preço do Produto: R$");
                    precoProduto[i] = Double.Parse(Console.ReadLine());
                }

                Console.Write("Informe a Quantidade do Produto em Estoque: ");
                estokProduto[i] = Int32.Parse(Console.ReadLine());
                while (estokProduto[i] < 0)
                {
                    Console.WriteLine("[ERRO!] Por favor Insira uma Quantidade Válida!");
                    Console.Write("Informe a Quantidade do Produto em Estoque: ");
                    estokProduto[i] = Int32.Parse(Console.ReadLine());
                }

                Console.WriteLine("");
                Console.WriteLine("================================");
            }

            Console.WriteLine("");
            Console.WriteLine("");

            //Definindo Tamanho das Colunas... Produto, Preço, Estoque

            int maiorNomeProduto = "produto".Length, maiorPreco = "preço".Length, maiorEstoque = "estoque".Length;

            for (int i = 0; i < nProdutos; i++) {
                if (maiorNomeProduto < nomeProduto[i].Length)
                {
                    maiorNomeProduto = nomeProduto[i].Length;
                }

                if (maiorPreco < $"R$ {precoProduto[i]}".Length)
                {
                    maiorPreco = $"R$ {precoProduto[i]}".Length;
                }

                if (maiorEstoque < $"{estokProduto[i]}".Length)
                {
                    maiorEstoque = $"{estokProduto[i]}".Length;
                }
            }

            //Formulando Tabela

            int nEspaco1, nEspaco2, nEspaco3;

            for (int i = 0; i < nProdutos; i++) {
                nEspaco1 = 5;
                nEspaco2 = 5;
                nEspaco3 = 5;

                if (i == 0)
                {
                    for (int c = 0; c < (maiorNomeProduto + maiorPreco + maiorEstoque) + 10; c++) {
                        if (c == (maiorNomeProduto + maiorPreco + maiorEstoque + 10))
                        {
                            Console.WriteLine("=");
                        }
                        else
                        {
                            Console.Write("=");
                        }
                    }
                    Console.WriteLine("");

                    //Primeira Linha

                    if ("Produto".Length < maiorNomeProduto)
                    {
                        nEspaco1 = (maiorNomeProduto - "Produto".Length) + 5;
                    }
                    Console.Write("Produto");
                    for (int c = 0; c < nEspaco1; c++) {
                        Console.Write(" ");
                    }

                    if ("Preço".Length < maiorPreco)
                    {
                        nEspaco2 = (maiorPreco - "Preço".Length) + 5;
                    }
                    Console.Write("Preço");
                    for (int c = 0; c < nEspaco2; c++) {
                        Console.Write(" ");
                    }

                    if ("Estoque".Length < maiorEstoque)
                    {
                        nEspaco3 = (maiorEstoque - "Estoque".Length) + 5;
                    }
                    
                    Console.Write("Estoque");
                    for (int c = 0; c < nEspaco3; c++) {
                        if (c == nEspaco3 - 1)
                        {
                            Console.WriteLine(" ");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }

                    //Segunda Linha

                    for (int c = 0; c < maiorNomeProduto; c++) {
                        Console.Write("=");
                    }
                    for (int c = 0; c < 5; c++) {
                        Console.Write(" ");
                    }

                    for (int c = 0; c < maiorPreco; c++) {
                        Console.Write("=");
                    }
                    for (int c = 0; c < 5; c++) {
                        Console.Write(" ");
                    }
                    
                    for (int c = 0; c < maiorEstoque; c++) {
                        if (c == maiorEstoque - 1)
                        {
                            Console.WriteLine("=");
                        }
                        else
                        {
                            Console.Write("=");
                        }
                    }

                }

                //Nome Produto
                if (nomeProduto[i].Length < maiorNomeProduto)
                {
                    nEspaco1 = (maiorNomeProduto - nomeProduto[i].Length) + 5;
                }
                Console.Write($"{nomeProduto[i]}");
                for (int c = 0; c < nEspaco1; c++) {
                    Console.Write(" ");
                }

                //Preço Produto
                if ($"R$ {precoProduto[i]}".Length < maiorPreco)
                {
                    nEspaco2 = (maiorPreco - $"R$ {precoProduto[i]}".Length) + 5;
                }
                Console.Write($"R$ {precoProduto[i]}");
                for (int c = 0; c < nEspaco2; c++) {
                    Console.Write(" ");
                }

                //Estoque Produto
                if ($"{estokProduto[i]}".Length < maiorEstoque)
                {
                    nEspaco3 = (maiorEstoque - $"{estokProduto}".Length) + 5;
                }
                Console.Write($"{estokProduto[i]}");
                for (int c = 0; c < nEspaco3; c++) {
                    Console.Write(" ");
                }

                Console.WriteLine("");
            }

            for (int c = 0; c < (maiorNomeProduto + maiorPreco + maiorEstoque) + 10; c++) {
                if (c == (maiorNomeProduto + maiorPreco + maiorEstoque + 10))
                {
                    Console.WriteLine("=");
                }
                else
                {
                    Console.Write("=");
                }
            }
        }
    }
}
