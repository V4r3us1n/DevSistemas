using System;

namespace exercicios1_20_04_2023
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

            string[,] participantesIBGE = new string[nParticipantesIBGE, 3];

            //Realizando a Coleta de Dados

            Console.WriteLine("==========================================");

            for (int i = 0; i < nParticipantesIBGE; i++) {
                Console.WriteLine($"PARTICIPANTE Nº {i + 1}...");
                Console.WriteLine("");
                Console.Write("Informe o Nome do Participante: ");
                participantesIBGE[i, 0] = Console.ReadLine();
                Console.WriteLine("");

                Console.Write("Informe Quantos Filhos o Participante Tem: ");
                participantesIBGE[i, 1] = Console.ReadLine();
                while (Int32.Parse(participantesIBGE[i, 1]) < 0)
                {
                    Console.WriteLine("[ERRO!] Por favor Insira um Número Válido!");
                    Console.Write("Informe Quantos Filhos o Participante Tem: ");
                    participantesIBGE[i, 1] = Console.ReadLine();
                }
                Console.WriteLine("");

                Console.Write("Informe o Salário do Participante: R$");
                participantesIBGE[i, 2] = Console.ReadLine();
                while (Double.Parse(participantesIBGE[i, 2]) < 0)
                {
                    Console.WriteLine("[ERRO!] Por favor Insira um Salário Válido!");
                    Console.Write("Informe o Salário do Participante: R$");
                    participantesIBGE[i, 2] = Console.ReadLine();
                }
                Console.WriteLine("");
                Console.WriteLine("==========================================");
            }
            Console.WriteLine("FIM DA COLETA DE DADOS");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Analisando Informações...");

            //Verificando a Média da Quantidade de Filhos

            for (int i = 0; i < nParticipantesIBGE; i++) {
                mediaNFilhos += Int32.Parse(participantesIBGE[i, 1]);
            }
            mediaNFilhos /= nParticipantesIBGE;

            //Calculando Média do Salário da População

            for (int i = 0; i < nParticipantesIBGE; i++) {
                mediaSalario += Double.Parse(participantesIBGE[i, 2]);
            }
            mediaSalario /= nParticipantesIBGE;

            //Verificando Maior Salário da População

            maiorSalario = Double.Parse(participantesIBGE[0, 2]);

            for (int i = 1; i < nParticipantesIBGE; i++) {
                if (Double.Parse(participantesIBGE[i, 2]) > maiorSalario)
                {
                    maiorSalario = Double.Parse(participantesIBGE[i, 2]);
                }
            }

            //Verificando Menor Salário da População

            menorSalario = Double.Parse(participantesIBGE[0, 2]);

            for (int i = 1; i < nParticipantesIBGE; i++) {
                if (Double.Parse(participantesIBGE[i, 2]) < menorSalario)
                {
                    menorSalario = Double.Parse(participantesIBGE[i, 2]);
                }
            }

            //Percentual de Pessoas com Salário Menor que o Mínimo

            for (int i = 0; i < nParticipantesIBGE; i++) {
                if (Double.Parse(participantesIBGE[i, 2]) < salarioMinimo)
                {
                    nPessoasMenorSalario++;
                }
            }
            nPessoasMenorSalario = (nPessoasMenorSalario / nParticipantesIBGE) * 100;

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
