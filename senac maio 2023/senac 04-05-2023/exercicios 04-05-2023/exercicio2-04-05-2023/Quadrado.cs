using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio2_04_05_2023
{
    public class Quadrado
    {
        public double Lado {get;set;}

        public double Area {get;set;}

        public Quadrado (double lado)
        {
            Lado = lado;
        }

        public double CalcAreaQ()
        {
            Area = Lado * Lado;

            return Area;
        }
    }
}