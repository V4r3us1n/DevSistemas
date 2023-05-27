using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio01.Classes
{
    public class CpfCadastradoException : Exception
    {
        public CpfCadastradoException(string msg) : base (msg)
        {
            
        }
    }
}