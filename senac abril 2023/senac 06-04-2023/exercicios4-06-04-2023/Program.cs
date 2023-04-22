using System;

namespace exercicios2_06_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicitar o Valor do Lado do Triângulo

            Console.Write("Informe o valor dos lados do Triângulo Equilátero...  ");
            double lado = Double.Parse(Console.ReadLine());

            //Calculando a Área

            double area = ((Math.Pow(lado, 2.0)) * (Math.Pow(3.0 , 0.5)))/4;

            //Imprimindo o Valor da Área

            Console.WriteLine($"De acordo com o tamanho dos lados do Triângulo Equilátero que foi informado, {lado}, o valor de sua área é {area}!");

        }
    }
}
