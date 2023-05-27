using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio2_17_05_2023
{
    public abstract class Funcionario
    {
        public string CPF {get;set;}
        public string Nome {get;set;}
        protected string Cargo {get;set;}
        protected double Salario {get;set;}

        public Funcionario(string cpf, string nome)
        {
            CPF = cpf;
            Nome = nome;
        }

        public abstract string DefinirCargo ();

        public abstract double CalcularSalario (double salario);
    }
}