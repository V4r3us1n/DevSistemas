using System;

namespace exercicio3_18_05_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            IAreaCalculavel[] calcularAreas = new IAreaCalculavel[10];
            calcularAreas[0] = new Circulo(3.5);
            calcularAreas[1] = new Quadrado(4);
            calcularAreas[2] = new Retangulo(3,5);
            calcularAreas[3] = new Quadrado(3.14);
            calcularAreas[4] = new Retangulo(5.15, 6.7);
            calcularAreas[5] = new Circulo(7.8);
            calcularAreas[6] = new Circulo(6.9);
            calcularAreas[7] = new Quadrado(2.66);
            calcularAreas[8] = new Retangulo(4.5, 9.1);
            calcularAreas[9] = new Retangulo(3.5, 1.2);

            for (int i = 0; i < calcularAreas.Length; i++)
            {
                Console.WriteLine($"Calculando {i+1}º Área: ");
                Console.WriteLine($"O Valor da Área é {calcularAreas[i].CalcularArea()}");
                Console.WriteLine("");
            }
        }
    }
}
