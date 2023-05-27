using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio2_04_05_2023
{
    public class Triangulo
    {
        public double Base {get;set;}

        public double Altura {get;set;}

        public double Area{get;set;}

        public Triangulo (double altura, double baseT)
        {
            Base = baseT;
            Altura = altura;
        }

        public double CalcAreaT()
        {
            Area = (Base * Altura) / 2;

            return Area;
        }
    }
}