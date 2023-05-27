using System;

namespace exercicio2_04_05_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //CRIAR CLASSE TRIÂNGULO

            //SOLICITAR  INFORMAÇÕES PARA CALCULAR ÁREA DO TRIÂNGULO

            Console.Write("Informe a Base do Triângulo: ");
            double baseTriangulo = Double.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.Write("Informe a Altura do Triângulo: ");
            double alturaTriangulo = Double.Parse(Console.ReadLine());

            Triangulo triangulo = new Triangulo(baseTriangulo, alturaTriangulo);

            Console.WriteLine("");

            Console.WriteLine($"Um Triângulo com uma Base de {triangulo.Base} e uma Altura de {triangulo.Altura} possui uma Área de {triangulo.CalcAreaT()}");
            Console.WriteLine("");

            //CRIAR CLASSE QUADRADO

            //SOLICITAR INFORMAÇÕES PARA CALCULAR ÁREA DO QUADRADO

            Console.Write("Informe o Tamanho do Lado do Quadrado: ");
            double ladoQuadrado = Double.Parse(Console.ReadLine());

            Quadrado quadrado = new Quadrado(ladoQuadrado);

            Console.WriteLine("");

            Console.WriteLine($"Um Quadrado com um Lado de Tamanho {quadrado.Lado} possui uma Área de {quadrado.CalcAreaQ()}");
            Console.WriteLine("");


            //CRIAR CLASSE RETÂNGULO

            //SOLICITAR INFORMAÇÕES PARA CALCULAR ÁREA DO RETÂNGULO

            Console.Write("Informe o 1º Lado do Retângulo: ");
            double lado1Retangulo = Double.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.Write("Informe o 2º Lado do Retângulo: ");
            double lado2Retangulo = Double.Parse(Console.ReadLine());

            Retangulo retangulo = new Retangulo(lado1Retangulo, lado2Retangulo);

            Console.WriteLine("");

            Console.WriteLine($"Um Retângulo com Lados de Valor {retangulo.Lado1} e {retangulo.Lado2} possui uma Área de {retangulo.CalcAreaR()}");
            Console.WriteLine("");
        }
    }
}
