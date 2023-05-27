using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio1_04_05_2023
{
    public class Circulo
    {
        public double Raio {get;set;}
        public double Area {get;set;}

        public const double pi = 3.14;

        //Atribuindo Valor de Raio
        public Circulo (double raio)
        {
            Raio = raio;
        }

        //Calculando Área

        public double CalcArea ()
        {
            Area = pi * (Raio * Raio);

            return Area;
        }

    }
}