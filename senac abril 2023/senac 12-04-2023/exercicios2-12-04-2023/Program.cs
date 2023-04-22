using System;

namespace exercicios2_12_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicitar as 4 Notas

            double nota1, nota2, nota3, nota4, media;
            string resultadoMedia;

            Console.Write("Informe a Primeira Nota... ");
            nota1 = Double.Parse(Console.ReadLine());

            Console.Write("Informe a Segunda Nota... ");
            nota2 = Double.Parse(Console.ReadLine());

            Console.Write("Informe a Terceira Nota... ");
            nota3 = Double.Parse(Console.ReadLine());

            Console.Write("Informe a Quarta Nota... ");
            nota4 = Double.Parse(Console.ReadLine());

            //Calcular Média
            media = (nota1 + nota2 + nota3 + nota4) / 4;

            //Está Aprovado ou Reprovado?

            if (media >= 7)
            {
                resultadoMedia = "APROVADO";
            }
            else if (media >= 5)
                {
                    resultadoMedia = "EM RECUPERAÇÃO";
                }
                else
                {
                    resultadoMedia = "REPROVADO";
                }

            Console.WriteLine($"Sua Média é {media}, você está {resultadoMedia}!");
        }
    }
}
