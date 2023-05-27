using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio01.Classes
{
    public class TipoCnpjInvalido : Exception
    {
        public TipoCnpjInvalido (string msg) : base(msg)
        {

        }
    }
}