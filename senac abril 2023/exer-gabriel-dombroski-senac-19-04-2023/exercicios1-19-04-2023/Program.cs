using System;

namespace exercicios1_19_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicitar ao Usuário a quantidade de notas a ser lançadas

            int quantidadeNotas;
            double media = 0;
            string situacaoAluno;

            Console.Write("Informe a quantidade de notas a serem lançadas... ");
            quantidadeNotas = Int32.Parse(Console.ReadLine());

            int[] notas = new int[quantidadeNotas];

            //Solicitando ao Usuário cada uma das Notas

            for (int i = 0; i < notas.Length; i++) {
                Console.Write($"Insira a {i + 1}ª Nota... ");
                notas[i] = Int32.Parse(Console.ReadLine());
            }

            //Calculando a Média do Aluno

            for (int i = 0; i < notas.Length; i++) {
                media += notas[i];
            }

            media /= quantidadeNotas;

            //Informando se o Aluno está Aprovado, em Recuperação ou Reprovado

            if (media >= 7)
            {
                situacaoAluno = "APROVADO";
            }
            else if (media >= 5)
            {
                situacaoAluno = "EM RECUPERAÇÃO";
            }
            else
            {
                situacaoAluno = "REPROVADO";
            }

            Console.WriteLine($"Prezado aluno, sua Média esse ano é {media}, você está {situacaoAluno}!");

        }
    }
}
