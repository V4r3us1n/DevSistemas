using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio3_24_05_2023
{
    public class TipoCnpjInvalido : Exception
    {
        public TipoCnpjInvalido (string msg) : base(msg)
        {

        }
    }
}