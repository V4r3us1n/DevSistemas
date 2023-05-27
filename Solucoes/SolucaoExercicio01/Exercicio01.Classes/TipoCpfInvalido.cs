using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio01.Classes
{
    public class TipoCpfInvalido : Exception
    {
        public TipoCpfInvalido (string msg) : base(msg)
        {

        }
    }
}