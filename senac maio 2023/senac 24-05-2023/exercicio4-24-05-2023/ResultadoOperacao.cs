using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio4_24_05_2023
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