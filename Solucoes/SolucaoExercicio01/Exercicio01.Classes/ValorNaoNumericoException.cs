using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio01.Classes
{
    public class ValorNaoNumericoException : Exception
    {
        public ValorNaoNumericoException (string msg) : base(msg)
        {
            
        }
    }
}