using System;

namespace exercicios2_05_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {

            var contagem = 1;

            while (contagem < 11) {
                if (contagem < 10) {
                    Console.WriteLine($"0{contagem}");

                    Console.WriteLine("Pressione Qualquer Tecla para continuar a contagem... ");
                    Console.ReadKey();

                } else {
                    Console.WriteLine(contagem);

                    Console.WriteLine("FIM DA CONTAGEM!");
                }
            
                contagem = contagem + 1;    
            }
        }
    }
}
