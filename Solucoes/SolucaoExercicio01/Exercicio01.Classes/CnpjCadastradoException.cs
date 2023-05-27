using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio01.Classes
{
    public class CnpjCadastradoException : Exception
    {
        public CnpjCadastradoException (string msg) : base (msg)
        {

        }
    }
}