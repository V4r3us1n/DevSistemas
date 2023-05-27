using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio3_18_05_2023
{
    public class Quadrado : IAreaCalculavel
    {
        public double Lado {get;set;}
        public double Area {get;set;}

        public Quadrado (double lado)
        {
            Lado = lado;
        }

        public double CalcularArea()
        {
            Area = Math.Pow(Lado,2);
            return Area;
        }
    }
}