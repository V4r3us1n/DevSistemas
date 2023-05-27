using System;

namespace projeto_26_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Correção Exercício IBGE

            string sair = "";
            double[] salario = new double[1];
            int[] nFilhos = new int[1];
            int i = 0;

            while (sair.ToLower() != "sair") 
            {
                if (i > 0)
                {
                    double[] salarioTemp = new double[salario.Length + 1];

                    for (int j = 0; j < salario.Length; j++)
                    {
                        salarioTemp[j] = salario[j];
                    }
                    salario = salarioTemp;

                    int[] nFilhosTemp = new int[nFilhos.Length + 1];

                    for (int j = 0; j < nFilhos.Length; j++)
                    {
                        nFilhosTemp[j] = nFilhos[j];
                    }
                    nFilhos = nFilhosTemp;
                }
                Console.Write("Digite o salário do pesquisado: ");
                salario[i] = Double.Parse(Console.ReadLine());

                Console.Write("Digite o número de filhos do pesquisado: ");
                nFilhos[i] = Int32.Parse(Console.ReadLine());

                Console.Write("Para sair da pesquisa digite 'sair': ");
                sair = Console.ReadLine();

                i++;
            }

            double somaSalario = 0;
            double somaFilhos = 0;
            double maiorSalario = 0;
            double menorSalario = 0;
            const double meioSalario = 600;
            int quantidadeMeioSalario = 0;

            for (i = 0; i < salario.Length; i++)
            {
                somaSalario += salario[i];

                if (maiorSalario < salario[i])
                {
                    maiorSalario = salario[i];
                }
                if (menorSalario == 0)
                {
                    menorSalario = salario[i];
                }
                else if (menorSalario > salario[i])
                {
                    menorSalario = salario[i];
                }
                if (salario[i] < meioSalario)
                {
                    quantidadeMeioSalario++;
                }

                somaFilhos += nFilhos[i];
            }

            Console.WriteLine("----Relatório----");
            Console.WriteLine($"Méida de Salário: {somaSalario / salario.Length}");
            Console.WriteLine($"Média de Filhos: {somaFilhos / nFilhos.Length}");
            Console.WriteLine($"Menor Salário: {menorSalario}");
            Console.WriteLine($"Maior Salário: {maiorSalario}");
            Console.WriteLine($"Porcentagem abaixo de meio salário: {((double)quantidadeMeioSalario / salario.Length)*100}%");
            */

            /*
            //Correção Produtos (Incompleto)

            int nProdutos;

            Console.Write("Informe a quantidade de produtos: ");
            nProdutos = Int32.Parse(Console.ReadLine());

            string[] nomeProduto = new string[nProdutos];

            for (int i = 0; i < nProdutos; i++)
            {
                Console.Write("Digite o Nome do Produto: ");
                nomeProduto[i] = Console.ReadLine();
            }
            Console.Clear();

            Console.WriteLine("Nome--------Valor--------Estoque");
            for (int i = 0; i < nProdutos; i++)
            {
                Console.WriteLine(nomeProduto[i]);
            }
            //A parte do TOTAL GERAL era para ser OUTRA COLUNA dentro do RELATÓRIO, representando  "preço do produto * total em estoque do produto"
            */

            
        }
    }
}
