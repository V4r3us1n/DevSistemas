using System;

namespace exercicios3_20_04_2023
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

            string[,] produto = new string[nProdutos, 3];

            //Definindo Informações Sobre Cada Produto...

            Console.WriteLine("================================");
            Console.WriteLine("");

            for (int i = 0; i < nProdutos; i++) {
                Console.WriteLine($"PRODUTO Nº{i + 1}");
                Console.WriteLine("");

                Console.Write("Informe o Nome do Produto: ");
                produto[i, 0] = Console.ReadLine();

                Console.Write("Informe o Preço do Produto: R$");
                produto[i, 1] = Console.ReadLine();
                while (Double.Parse(produto[i, 1]) < 0.01)
                {
                    Console.WriteLine("[ERRO!] Por favor Insira um Valor Válido!");
                    Console.Write("Informe o Preço do Produto: R$");
                    produto[i, 1] = Console.ReadLine();
                }

                Console.Write("Informe a Quantidade do Produto em Estoque: ");
                produto[i, 2] = Console.ReadLine();
                while (Int32.Parse(produto[i, 2]) < 0)
                {
                    Console.WriteLine("[ERRO!] Por favor Insira um Valor Válido!");
                    Console.Write("Informe a Quantidade do Produto em Estoque: ");
                    produto[i, 2] = Console.ReadLine();
                }

                Console.WriteLine("");
                Console.WriteLine("================================");
            }

            Console.WriteLine("");
            Console.WriteLine("");

            //Definindo Tamanho das Colunas... Produto, Preço, Estoque

            int maiorNomeProduto = "produto".Length, maiorPreco = "preço".Length, maiorEstoque = "estoque".Length;

            for (int i = 0; i < nProdutos; i++) {
                if (maiorNomeProduto < produto[i, 0].Length)
                {
                    maiorNomeProduto = produto[i, 0].Length;
                }

                if (maiorPreco < $"R$ {produto[i, 1]}".Length)
                {
                    maiorPreco = $"R$ {produto[i, 1]}".Length;
                }

                if (maiorEstoque < $"{produto[i, 2]}".Length)
                {
                    maiorEstoque = $"{produto[i, 2]}".Length;
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
                if (produto[i, 0].Length < maiorNomeProduto)
                {
                    nEspaco1 = (maiorNomeProduto - produto[i, 0].Length) + 5;
                }
                Console.Write($"{produto[i, 0]}");
                for (int c = 0; c < nEspaco1; c++) {
                    Console.Write(" ");
                }

                //Preço Produto
                if ($"R$ {produto[i, 1]}".Length < maiorPreco)
                {
                    nEspaco2 = (maiorPreco - $"R$ {produto[i, 1]}".Length) + 5;
                }
                Console.Write($"R$ {produto[i, 1]}");
                for (int c = 0; c < nEspaco2; c++) {
                    Console.Write(" ");
                }

                //Estoque Produto
                if ($"{produto[i, 2]}".Length < maiorEstoque)
                {
                    nEspaco3 = (maiorEstoque - $"{produto[i, 2]}".Length) + 5;
                }
                Console.Write($"{produto[i, 2]}");
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
