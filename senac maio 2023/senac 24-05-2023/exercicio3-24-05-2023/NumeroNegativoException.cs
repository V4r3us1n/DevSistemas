using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio3_24_05_2023
{
    public class NumeroNegativoException : Exception
    {
        public NumeroNegativoException(string msg) : base(msg)
        {

        }
    }
}