using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio03.Classes
{
    public class Circulo : IAreaCalculavel
    {
        public double Raio {get;set;}
        public const double PI = 3.14;

        public double Area {get;set;}

        public Circulo (double raio)
        {
            Raio = raio;
        }

        public double CalcularArea()
        {
            Area = PI*(Math.Pow(Raio,2));
            return Area;
        }
    }
}