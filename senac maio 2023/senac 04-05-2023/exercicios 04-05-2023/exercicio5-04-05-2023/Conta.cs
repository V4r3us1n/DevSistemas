using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio5_04_05_2023
{
    public class Conta
    {
        public int NumeroConta {get;set;}
        public Correntista CorrentistaConta {get;set;}
        public double Saldo {get;set;}

        public Conta(int numeroConta, Correntista correntistaConta, double saldo)
        {
            NumeroConta = numeroConta;
            CorrentistaConta = correntistaConta;
            Saldo = saldo;
        }
    }
}