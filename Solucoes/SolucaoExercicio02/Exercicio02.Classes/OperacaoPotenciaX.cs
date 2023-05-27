using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio02.Classes
{
    public class OperacaoPotenciaX : OperacaoAritmetica
    {
        public OperacaoPotenciaX(double valor1, double valor2) : base(valor1, valor2)
        {
            Valor1 = valor1;
            Valor2 = valor2;
        }

        public override double Calcular()
        {
            Resultado = Math.Pow(Valor1, Valor2);
            
            return Resultado;
        }
    }
}