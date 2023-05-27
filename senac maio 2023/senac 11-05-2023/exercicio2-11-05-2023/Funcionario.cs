using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio2_11_05_2023
{
    public class Funcionario
    {
        public string CPF {get;set;}
        public string Nome {get;set;}
        public double Salario {get;set;}

        public Funcionario (string cpf, string nome, double salario)
        {
            CPF = cpf;
            Nome = nome;
            Salario = salario;
        }

        public virtual void CalcSalario(double salario)
        {
            salario = Salario;
            Salario = salario;
        }
    }
}