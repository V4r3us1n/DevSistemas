using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio4_24_05_2023
{
    public abstract class OperacaoAritmetica
    {
        public double Valor1 {get;set;}
        public double Valor2 {get;set;}
        protected double Resultado {get;set;}
        public OperacaoAritmetica(double valor1, double valor2)
        {
            Valor1 = valor1;
            Valor2 = valor2;
        }

        public abstract double Calcular();
    }
}