using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio4_17_05_2023
{
    public abstract class Funcionario
    {
        public string CPF {get;set;}
        public string Nome {get;set;}
        protected string Cargo {get;set;}
        protected double Salario {get;set;}
        protected double Imposto {get;set;}

        public const double SalarioF0 = 1903.98;
        public const double SalarioF1 = 2826.65;
        public const double SalarioF2 = 3751.05;
        public const double SalarioF3 = 4664.68;

        public Funcionario (string cpf, string nome)
        {
            CPF = cpf;
            Nome = nome;
        }

        public abstract string DefinirCargo();

        public abstract double CalcSalario(double salario);

        public abstract double CalcImposto();
    }
}