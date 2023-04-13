using System;

namespace exercicios1_12_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicitar os 3 lados do triângulo em cm

            double lado1, lado2, lado3;
            string triangulo;

            Console.Write("Informe o tamanho, em cm, do primeiro lado do triângulo... ");
            lado1 = Double.Parse(Console.ReadLine());

            Console.Write("Informe o tamanho, em cm, do segundo lado do triângulo... ");
            lado2 = Double.Parse(Console.ReadLine());

            Console.Write("Informe o tamanho, em cm, do terceiro lado do triângulo... ");
            lado3 = Double.Parse(Console.ReadLine());

            //Verificar o tipo de triângulo...

            if (lado1 == lado2 && lado2 == lado3)
            {
                triangulo = "EQUILÁTERO";
            }
            else if (lado1 != lado2 && lado2 != lado3 && lado1 != lado3)
                {
                    triangulo = "ESCALENO";
                }
                else
                {
                    triangulo = "ISÓSCELES";
                }

            Console.WriteLine($"De acordo com os valores inseridos ({lado1}cm, {lado2}cm e {lado3}cm), se trata de um Triângulo {triangulo}!");
        }
    }
}
