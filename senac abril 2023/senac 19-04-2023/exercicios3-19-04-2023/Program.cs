using System;

namespace exercicios3_19_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Considere a Seguinte Frase

            string frase = "A única constante é a mudança";
            int limitePalavra = 0, novaPalavra = 0;

            string[] palavrasFrase = new string[6];

            for (int i = 0; i < frase.Length; i++) {
                if ($"{frase[i]}" == " ")
                {
                    for (int c = limitePalavra; c < i; c++) {
                        palavrasFrase[novaPalavra] += frase[c];
                    }
                    limitePalavra = i + 1;
                    novaPalavra++;
                }
                else if (i == frase.Length - 1)
                {
                    for (int c = limitePalavra; c <= i; c++) {
                        palavrasFrase[novaPalavra] += frase[c];
                    }
                    limitePalavra = i + 1;
                    novaPalavra++;
                }
            }

            //Exibindo cada Palavra da Frase

            for (int i = 0; i < palavrasFrase.Length; i ++) {
                Console.WriteLine($"{i + 1}ª Palavra da Frase: '{palavrasFrase[i]}'");
            }
        }
    }
}
