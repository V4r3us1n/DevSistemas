using System;

namespace exercicios3_19_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Considere a Seguinte Frase

            string frase = "A única constante é a mudança";
            
            string[] palavrasFrase = frase.Split(' ');

            for (int i = 0; i < palavrasFrase.Length; i++) {
                Console.WriteLine($"Palavra Nº{i + 1}: {palavrasFrase[i]}");
            }
        }
    }
}
