using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio3_18_05_2023
{
    public class Retangulo : IAreaCalculavel
    {
        public double Lado1 {get;set;}
        public double Lado2 {get;set;}
        public double Area {get;set;}

        public Retangulo (double lado1, double lado2)
        {
            Lado1 = lado1;
            Lado2 = lado2;
        }

        public double CalcularArea()
        {
            Area = Lado1 * Lado2;
            return Area;
        }
    }
}