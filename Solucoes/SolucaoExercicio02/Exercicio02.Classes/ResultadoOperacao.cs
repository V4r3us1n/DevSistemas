using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio02.Classes
{
    public class ResultadoOperacao
    {

        public OperacaoAritmetica Resultado {get;set;}

        public ResultadoOperacao(OperacaoAritmetica resultado)
        {
            Resultado = resultado;
        }

        public double ExibirResultado()
        {
            return Resultado.Calcular();
        }
    }
}