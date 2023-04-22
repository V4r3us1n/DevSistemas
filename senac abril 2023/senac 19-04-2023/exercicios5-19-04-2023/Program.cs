using System;

namespace exercicios5_19_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicitando Informações pro IBGE: Salário e Número de Filhos

            const double salarioMinimo = 1212;
            int nParticipantesIBGE, mediaNFilhos = 0;
            double mediaSalario = 0, maiorSalario, menorSalario, nPessoasMenorSalario = 0;

            Console.Write("Informe quantas pessoas estão participando do IBGE 2022... ");
            nParticipantesIBGE = Int32.Parse(Console.ReadLine());

            //Definindo Tamanho dos Arrays

            string[] nomeParticipantes = new string[nParticipantesIBGE];
            int[] nFilhos = new int[nParticipantesIBGE];
            double[] salario = new double[nParticipantesIBGE];

            //Realizando a Coleta de Dados

            Console.WriteLine("==========================================");

            for (int i = 0; i < nParticipantesIBGE; i++) {
                Console.WriteLine($"PARTICIPANTE Nº {i + 1}...");
                Console.WriteLine("");
                Console.Write("Informe o Nome do Participante: ");
                nomeParticipantes[i] = Console.ReadLine();
                Console.WriteLine("");

                Console.Write("Informe Quantos Filhos o Participante Tem: ");
                nFilhos[i] = Int32.Parse(Console.ReadLine());
                while (nFilhos[i] < 0)
                {
                    Console.WriteLine("[ERRO!] Não é possível ter uma quantidade de filhos NEGATIVO!");
                    Console.Write("Informe Quantos Filhos o Participante Tem: ");
                    nFilhos[i] = Int32.Parse(Console.ReadLine());
                }
                Console.WriteLine("");

                Console.Write("Informe o Salário do Participante: R$");
                salario[i] = Double.Parse(Console.ReadLine());
                while (salario[i] < 0)
                {
                    Console.WriteLine("[ERRO!] Você não pode possuir um SALÁRIO NEGATIVO!");
                    Console.Write("Informe o Salário do Participante: R$");
                    salario[i] = Double.Parse(Console.ReadLine());
                }
                Console.WriteLine("");
                Console.WriteLine("==========================================");
            }
            Console.WriteLine("FIM DA COLETA DE DADOS");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Analisando Informações...");

            //Verificando a Média da Quantidade de Filhos

            for (int i = 0; i < nFilhos.Length; i++) {
                mediaNFilhos += nFilhos[i];
            }
            mediaNFilhos /= nFilhos.Length;

            //Calculando Média do Salário da População

            for (int i = 0; i < salario.Length; i++) {
                mediaSalario += salario[i];
            }
            mediaSalario /= salario.Length;

            //Verificando Maior Salário da População

            maiorSalario = salario[0];

            for (int i = 1; i < salario.Length; i++) {
                if (salario[i] > maiorSalario)
                {
                    maiorSalario = salario[i];
                }
            }

            //Verificando Menor Salário da População

            menorSalario = salario[0];

            for (int i = 1; i < salario.Length; i++) {
                if (salario[i] < menorSalario)
                {
                    menorSalario = salario[i];
                }
            }

            //Percentual de Pessoas com Salário Menor que o Mínimo

            for (int i = 0; i < salario.Length; i++) {
                if (salario[i] < salarioMinimo)
                {
                    nPessoasMenorSalario++;
                }
            }
            nPessoasMenorSalario = (nPessoasMenorSalario / salario.Length) * 100;

            //Imprimindo Resultados

            Console.WriteLine("RESULTADO IBGE 2022");
            Console.WriteLine("");
            Console.WriteLine($"Média do Salário da População: R${mediaSalario}");
            Console.WriteLine($"Média do Número de Filhos: {mediaNFilhos}");
            Console.WriteLine($"Maior Salário: R${maiorSalario}");
            Console.WriteLine($"Menor Salário: R${menorSalario}");
            Console.WriteLine($"Percentual de Pessoas com Salário Menor que o Salário Mínimo: {nPessoasMenorSalario}%");
        }
    }
}
