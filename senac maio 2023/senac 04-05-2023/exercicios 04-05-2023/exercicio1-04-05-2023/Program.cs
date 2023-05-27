using System;

namespace exercicio1_04_05_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //CRIAR CLASSE CIRCULO

            //Solicitando Valor de Raio

            Console.Write("Informe o Raio  do Círculo: ");
            double valorRaio = Double.Parse(Console.ReadLine());

            Circulo circulo = new Circulo(valorRaio);

            //IMPRIMINDO RESULTADOS

            //circulo.RaioCirculo(valorRaio);

            Console.WriteLine("");
            Console.WriteLine($"Um Círculo com um Raio de {circulo.Raio} possui uma Área de {circulo.CalcArea()}");
            Console.WriteLine("");
        }
    }
}
