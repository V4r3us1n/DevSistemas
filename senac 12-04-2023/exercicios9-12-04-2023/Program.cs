using System;

namespace exercicios9_12_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicitando a Idade da pessoa

            byte idade;
            double peso;

            Console.Write("Informe a sua Idade... ");
            idade = Byte.Parse(Console.ReadLine());
            Console.Write("Informe seu Peso... Kg");
            peso = Double.Parse(Console.ReadLine());

            if (idade < 18 || idade > 65)
            {
                Console.WriteLine("Infelizmente você não pode doar sangue devido à sua idade!");
            }
            else if (peso < 50 || peso > 120)
            {
                Console.WriteLine("Infelizmente você não pode doar sangue devido ao seu peso!");
            }
            else
            {
                Console.WriteLine("Você está apto para doar sangue, por favor prossiga com o processo!");
            }
        }
    }
}
