using System;

namespace exercicio1_26_04_2023
{
    class Program
    {

        static double[] salario = new double[1];
        static int[] nFilhos = new int[1];
        static double metadeSalarioMinimo = 1212/2;

        static int i = 0;

        static void Main(string[] args)
        {

            string continuarSensoIBGE = "";

            do {
                Console.WriteLine("=======================================");
                Console.WriteLine("");

                Console.WriteLine($"PARTICIPANTE Nº{i + 1}");
                Console.WriteLine("");

                Console.Write("Informe o Salário do Participante: ");
                salario[i] = Double.Parse(Console.ReadLine());

                Console.Write("Informe a Quantidade de Filhos do Participante: ");
                nFilhos[i] = Int32.Parse(Console.ReadLine());

                Console.WriteLine("");
                Console.WriteLine("=======================================");

                Console.Write("Deseja Continuar o Senso? ");
                continuarSensoIBGE = Console.ReadLine();

                if (continuarSensoIBGE.ToLower() == "sim")
                {
                    AumentandoArrayNFilhos();
                    AumentandoArraySalario();

                    i++;
                }

            } while (continuarSensoIBGE.ToLower() == "sim");

            Console.WriteLine("");

            Console.WriteLine("EXIBINDO RELATÓRIO DO SENSO DO IBGE 2022!");
            Console.WriteLine("");
            Console.WriteLine("=====================================================================================");
            Console.WriteLine("");

            Console.WriteLine($"Média do Salário da População: R${MediaSalario()}");
            Console.WriteLine($"Média do Número de Filhos da População: {MediaFilhos()}");
            Console.WriteLine($"Maior Salário entre a População: R${MaiorSalario()}");
            Console.WriteLine($"Menor Salário entre a População: R${MenorSalario()}");
            Console.WriteLine($"Percentual de Pessoas com Salário a Baixo da Metade do Salário Mínimo: {PercentualMetadeSalarioMinimo()}%");

            Console.WriteLine("");
            Console.WriteLine("=====================================================================================");
            Console.WriteLine("");
            Console.WriteLine("FIM DO PROGRAMA!");

        }

        static void AumentandoArraySalario()
        {
            double[] salarioTemp = new double[salario.Length + 1];

            for (int j = 0; j < salario.Length; j++)
            {
                salarioTemp[j] = salario[j];
            }

            salario = salarioTemp;
        }

        static void AumentandoArrayNFilhos()
        {
            int[] nFilhosTemp = new int[nFilhos.Length + 1];

            for (int j = 0; j < nFilhos.Length; j++)
            {
                nFilhosTemp[j] = nFilhos[j];
            }

            nFilhos = nFilhosTemp;
        }

        static double MediaSalario()
        {
            double mediaSalario = 0;

            for (int j = 0; j < salario.Length; j++)
            {
                mediaSalario += salario[j];
            }

            mediaSalario /= i;

            return mediaSalario;
        }

        static double MenorSalario()
        {
            double menorSalario = salario[0];

            for (int j = 1; j < salario.Length; j++)
            {
                if (salario[j] < menorSalario)
                {
                    menorSalario = salario[j];
                }
            }

            return menorSalario;
        }

        static double MaiorSalario()
        {
            double maiorSalario = salario[0];

            for (int j = 1; j < salario.Length; j++)
            {
                if (maiorSalario < salario[j])
                {
                    maiorSalario = salario[j];
                }
            }

            return maiorSalario;
        }

        static int MediaFilhos()
        {
            int mediaFilhos = 0;

            for (int j = 0; j < nFilhos.Length; j++)
            {
                mediaFilhos += nFilhos[j];
            }

            mediaFilhos /= nFilhos.Length;

            return mediaFilhos;
        }

        static double PercentualMetadeSalarioMinimo()
        {
            double percentualMetadeSalarioMinimo = 0;

            for (int j = 0; j < salario.Length; j++)
            {
                if (salario[j] < metadeSalarioMinimo)
                {
                    percentualMetadeSalarioMinimo++;
                }
            }

            percentualMetadeSalarioMinimo = (percentualMetadeSalarioMinimo / salario.Length) * 100;

            return percentualMetadeSalarioMinimo;
        }
    }
}
