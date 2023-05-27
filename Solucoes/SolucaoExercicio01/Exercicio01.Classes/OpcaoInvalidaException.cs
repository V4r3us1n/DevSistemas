using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio01.Classes
{
    public class OpcaoInvalidaException : Exception
    {
        public OpcaoInvalidaException (string msg) : base(msg)
        {
            
        }
    }
}